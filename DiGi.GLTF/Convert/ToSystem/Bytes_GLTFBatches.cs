using DiGi.GLTF.Classes;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DiGi.GLTF
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts the specified <see cref="GLTFScene"/> into a byte array representing a binary glTF (.glb) file, optionally batching the node geometry.
        /// <para>When <paramref name="batched"/> is true, all nodes are merged into one draw unit per alpha mode (see <see cref="Create.GLTFBatches"/>): per-object styling is baked into vertex colors, per-object identity is encoded in the _OBJECTID vertex attribute and the object identity map is stored in the scene extras. This reduces thousands of WebGL draw calls to one or two.</para>
        /// </summary>
        /// <param name="gLTFScene">The <see cref="GLTFScene"/> instance to convert. This value can be null.</param>
        /// <param name="batched">A value indicating whether the node geometry is merged into batched draw units.</param>
        /// <returns>A byte array containing the GLB data, or null if the scene is null or has no geometry.</returns>
        public static byte[]? ToSystem_Bytes(this GLTFScene? gLTFScene, bool batched)
        {
            if (gLTFScene is null)
            {
                return null;
            }

            if (!batched)
            {
                return ToSystem_Bytes(gLTFScene);
            }

            List<GLTFBatch>? gLTFBatches = Create.GLTFBatches(gLTFScene, out List<GLTFBatchEntry> gLTFBatchEntries);
            if (gLTFBatches is null || gLTFBatches.Count == 0)
            {
                return ToSystem_Bytes(gLTFScene);
            }

            return ToSystem_Bytes(gLTFBatches, gLTFBatchEntries, gLTFScene.Name, gLTFScene);
        }

        /// <summary>
        /// Converts the specified <see cref="GLTFBatch"/> draw units into a byte array representing a binary glTF (.glb) file.
        /// <para>The binary buffer is packed directly from the batch arrays into a single allocation (positions as float32, colors as normalized unsigned byte RGBA, object ids as float32, indices as unsigned int32), minimizing memory overhead. The object identity map is written to the scene extras as objectMap so viewers can resolve picked object ids back to references and properties.</para>
        /// </summary>
        /// <param name="gLTFBatches">The <see cref="GLTFBatch"/> draw units to serialize. This value can be null.</param>
        /// <param name="gLTFBatchEntries">The identity entries of the batched objects; the list index of an entry is the object id encoded in the vertex attribute. This value can be null.</param>
        /// <param name="name">The optional display name of the scene.</param>
        /// <param name="gLTFScene_Configuration">The optional <see cref="GLTFScene"/> whose configuration (reference point, lights, camera) is embedded in the scene extras as sceneConfiguration, making the GLB payload fully self-describing for streamed delivery. This value can be null.</param>
        /// <returns>A byte array containing the GLB data, or null if <paramref name="gLTFBatches"/> is null or empty.</returns>
        public static byte[]? ToSystem_Bytes(this IEnumerable<GLTFBatch>? gLTFBatches, IEnumerable<GLTFBatchEntry>? gLTFBatchEntries, string? name = null, GLTFScene? gLTFScene_Configuration = null)
        {
            if (gLTFBatches is null)
            {
                return null;
            }

            List<GLTFBatch> gLTFBatches_Temp = [];
            foreach (GLTFBatch gLTFBatch in gLTFBatches)
            {
                if (gLTFBatch is not null && gLTFBatch.Positions.Length > 0 && gLTFBatch.Indexes.Length > 0)
                {
                    gLTFBatches_Temp.Add(gLTFBatch);
                }
            }

            if (gLTFBatches_Temp.Count == 0)
            {
                return null;
            }

            // Binary buffer layout: per batch [positions | colors | objectIds | indices].
            // All sections are naturally 4-byte aligned (float32, 4 x uint8 per vertex, float32, uint32).
            int[][] byteOffsets = new int[gLTFBatches_Temp.Count][];
            int binaryLength = 0;
            for (int i = 0; i < gLTFBatches_Temp.Count; i++)
            {
                GLTFBatch gLTFBatch = gLTFBatches_Temp[i];
                byteOffsets[i] = new int[4];
                byteOffsets[i][0] = binaryLength;
                binaryLength += gLTFBatch.Positions.Length * sizeof(float);
                byteOffsets[i][1] = binaryLength;
                binaryLength += gLTFBatch.Colors.Length;
                byteOffsets[i][2] = binaryLength;
                binaryLength += gLTFBatch.ObjectIds.Length * sizeof(float);
                byteOffsets[i][3] = binaryLength;
                binaryLength += gLTFBatch.Indexes.Length * sizeof(int);
            }

            byte[] jsonBytes = ToSystem_Bytes_GLTFJson(gLTFBatches_Temp, byteOffsets, binaryLength, gLTFBatchEntries, name, gLTFScene_Configuration);

            int jsonPaddedLength = (jsonBytes.Length + 3) / 4 * 4;
            int binaryPaddedLength = (binaryLength + 3) / 4 * 4;

            // GLB container: 12 byte header + JSON chunk (8 byte header) + BIN chunk (8 byte header).
            int totalLength = 12 + 8 + jsonPaddedLength + 8 + binaryPaddedLength;

            // Single allocation for the whole payload; sections are block-copied directly into place.
            byte[] result = new byte[totalLength];

            WriteUInt32(result, 0, 0x46546C67);                     // 'glTF'
            WriteUInt32(result, 4, 2);                              // container version
            WriteUInt32(result, 8, (uint)totalLength);

            WriteUInt32(result, 12, (uint)jsonPaddedLength);
            WriteUInt32(result, 16, 0x4E4F534A);                    // 'JSON'
            System.Buffer.BlockCopy(jsonBytes, 0, result, 20, jsonBytes.Length);
            for (int i = 20 + jsonBytes.Length; i < 20 + jsonPaddedLength; i++)
            {
                result[i] = 0x20;                                   // JSON chunks are padded with spaces
            }

            int binaryChunkStart = 20 + jsonPaddedLength;
            WriteUInt32(result, binaryChunkStart, (uint)binaryPaddedLength);
            WriteUInt32(result, binaryChunkStart + 4, 0x004E4942);  // 'BIN'

            int binaryDataStart = binaryChunkStart + 8;
            for (int i = 0; i < gLTFBatches_Temp.Count; i++)
            {
                GLTFBatch gLTFBatch = gLTFBatches_Temp[i];
                System.Buffer.BlockCopy(gLTFBatch.Positions, 0, result, binaryDataStart + byteOffsets[i][0], gLTFBatch.Positions.Length * sizeof(float));
                System.Buffer.BlockCopy(gLTFBatch.Colors, 0, result, binaryDataStart + byteOffsets[i][1], gLTFBatch.Colors.Length);
                System.Buffer.BlockCopy(gLTFBatch.ObjectIds, 0, result, binaryDataStart + byteOffsets[i][2], gLTFBatch.ObjectIds.Length * sizeof(float));
                System.Buffer.BlockCopy(gLTFBatch.Indexes, 0, result, binaryDataStart + byteOffsets[i][3], gLTFBatch.Indexes.Length * sizeof(int));
            }

            return result;
        }

        private static byte[] ToSystem_Bytes_GLTFJson(List<GLTFBatch> gLTFBatches, int[][] byteOffsets, int binaryLength, IEnumerable<GLTFBatchEntry>? gLTFBatchEntries, string? name, GLTFScene? gLTFScene_Configuration)
        {
            using MemoryStream memoryStream = new();
            using (Utf8JsonWriter utf8JsonWriter = new(memoryStream))
            {
                utf8JsonWriter.WriteStartObject();

                utf8JsonWriter.WriteStartObject("asset");
                utf8JsonWriter.WriteString("version", "2.0");
                utf8JsonWriter.WriteString("generator", "DiGi.GLTF");
                utf8JsonWriter.WriteEndObject();

                utf8JsonWriter.WriteStartArray("buffers");
                utf8JsonWriter.WriteStartObject();
                utf8JsonWriter.WriteNumber("byteLength", binaryLength);
                utf8JsonWriter.WriteEndObject();
                utf8JsonWriter.WriteEndArray();

                utf8JsonWriter.WriteStartArray("bufferViews");
                for (int i = 0; i < gLTFBatches.Count; i++)
                {
                    GLTFBatch gLTFBatch = gLTFBatches[i];
                    WriteBufferView(utf8JsonWriter, byteOffsets[i][0], gLTFBatch.Positions.Length * sizeof(float), 34962);
                    WriteBufferView(utf8JsonWriter, byteOffsets[i][1], gLTFBatch.Colors.Length, 34962);
                    WriteBufferView(utf8JsonWriter, byteOffsets[i][2], gLTFBatch.ObjectIds.Length * sizeof(float), 34962);
                    WriteBufferView(utf8JsonWriter, byteOffsets[i][3], gLTFBatch.Indexes.Length * sizeof(int), 34963);
                }
                utf8JsonWriter.WriteEndArray();

                utf8JsonWriter.WriteStartArray("accessors");
                for (int i = 0; i < gLTFBatches.Count; i++)
                {
                    GLTFBatch gLTFBatch = gLTFBatches[i];
                    int vertexCount = gLTFBatch.ObjectIds.Length;
                    int bufferViewIndex = i * 4;

                    // POSITION (min/max are required by the glTF specification).
                    utf8JsonWriter.WriteStartObject();
                    utf8JsonWriter.WriteNumber("bufferView", bufferViewIndex);
                    utf8JsonWriter.WriteNumber("componentType", 5126);
                    utf8JsonWriter.WriteNumber("count", vertexCount);
                    utf8JsonWriter.WriteString("type", "VEC3");
                    utf8JsonWriter.WriteStartArray("min");
                    utf8JsonWriter.WriteNumberValue(gLTFBatch.Min[0]);
                    utf8JsonWriter.WriteNumberValue(gLTFBatch.Min[1]);
                    utf8JsonWriter.WriteNumberValue(gLTFBatch.Min[2]);
                    utf8JsonWriter.WriteEndArray();
                    utf8JsonWriter.WriteStartArray("max");
                    utf8JsonWriter.WriteNumberValue(gLTFBatch.Max[0]);
                    utf8JsonWriter.WriteNumberValue(gLTFBatch.Max[1]);
                    utf8JsonWriter.WriteNumberValue(gLTFBatch.Max[2]);
                    utf8JsonWriter.WriteEndArray();
                    utf8JsonWriter.WriteEndObject();

                    // COLOR_0 (normalized RGBA bytes).
                    utf8JsonWriter.WriteStartObject();
                    utf8JsonWriter.WriteNumber("bufferView", bufferViewIndex + 1);
                    utf8JsonWriter.WriteNumber("componentType", 5121);
                    utf8JsonWriter.WriteBoolean("normalized", true);
                    utf8JsonWriter.WriteNumber("count", vertexCount);
                    utf8JsonWriter.WriteString("type", "VEC4");
                    utf8JsonWriter.WriteEndObject();

                    // _OBJECTID (custom attribute encoding the original object identity per vertex).
                    utf8JsonWriter.WriteStartObject();
                    utf8JsonWriter.WriteNumber("bufferView", bufferViewIndex + 2);
                    utf8JsonWriter.WriteNumber("componentType", 5126);
                    utf8JsonWriter.WriteNumber("count", vertexCount);
                    utf8JsonWriter.WriteString("type", "SCALAR");
                    utf8JsonWriter.WriteEndObject();

                    // Indices.
                    utf8JsonWriter.WriteStartObject();
                    utf8JsonWriter.WriteNumber("bufferView", bufferViewIndex + 3);
                    utf8JsonWriter.WriteNumber("componentType", 5125);
                    utf8JsonWriter.WriteNumber("count", gLTFBatch.Indexes.Length);
                    utf8JsonWriter.WriteString("type", "SCALAR");
                    utf8JsonWriter.WriteEndObject();
                }
                utf8JsonWriter.WriteEndArray();

                utf8JsonWriter.WriteStartArray("materials");
                for (int i = 0; i < gLTFBatches.Count; i++)
                {
                    utf8JsonWriter.WriteStartObject();
                    utf8JsonWriter.WriteString("name", gLTFBatches[i].Blended ? "Batched blended" : "Batched opaque");
                    utf8JsonWriter.WriteStartObject("pbrMetallicRoughness");
                    utf8JsonWriter.WriteStartArray("baseColorFactor");
                    utf8JsonWriter.WriteNumberValue(1);
                    utf8JsonWriter.WriteNumberValue(1);
                    utf8JsonWriter.WriteNumberValue(1);
                    utf8JsonWriter.WriteNumberValue(1);
                    utf8JsonWriter.WriteEndArray();
                    utf8JsonWriter.WriteNumber("metallicFactor", 0);
                    utf8JsonWriter.WriteNumber("roughnessFactor", 0.9);
                    utf8JsonWriter.WriteEndObject();
                    utf8JsonWriter.WriteBoolean("doubleSided", true);
                    if (gLTFBatches[i].Blended)
                    {
                        utf8JsonWriter.WriteString("alphaMode", "BLEND");
                    }
                    utf8JsonWriter.WriteEndObject();
                }
                utf8JsonWriter.WriteEndArray();

                utf8JsonWriter.WriteStartArray("meshes");
                for (int i = 0; i < gLTFBatches.Count; i++)
                {
                    utf8JsonWriter.WriteStartObject();
                    utf8JsonWriter.WriteString("name", gLTFBatches[i].Blended ? "Batch blended" : "Batch opaque");
                    utf8JsonWriter.WriteStartArray("primitives");
                    utf8JsonWriter.WriteStartObject();
                    utf8JsonWriter.WriteStartObject("attributes");
                    utf8JsonWriter.WriteNumber("POSITION", i * 4);
                    utf8JsonWriter.WriteNumber("COLOR_0", i * 4 + 1);
                    utf8JsonWriter.WriteNumber("_OBJECTID", i * 4 + 2);
                    utf8JsonWriter.WriteEndObject();
                    utf8JsonWriter.WriteNumber("indices", i * 4 + 3);
                    utf8JsonWriter.WriteNumber("material", i);
                    utf8JsonWriter.WriteNumber("mode", 4);
                    utf8JsonWriter.WriteEndObject();
                    utf8JsonWriter.WriteEndArray();
                    utf8JsonWriter.WriteEndObject();
                }
                utf8JsonWriter.WriteEndArray();

                utf8JsonWriter.WriteStartArray("nodes");
                for (int i = 0; i < gLTFBatches.Count; i++)
                {
                    utf8JsonWriter.WriteStartObject();
                    utf8JsonWriter.WriteNumber("mesh", i);
                    utf8JsonWriter.WriteEndObject();
                }
                utf8JsonWriter.WriteEndArray();

                utf8JsonWriter.WriteStartArray("scenes");
                utf8JsonWriter.WriteStartObject();
                if (name is not null)
                {
                    utf8JsonWriter.WriteString("name", name);
                }
                utf8JsonWriter.WriteStartArray("nodes");
                for (int i = 0; i < gLTFBatches.Count; i++)
                {
                    utf8JsonWriter.WriteNumberValue(i);
                }
                utf8JsonWriter.WriteEndArray();

                // The object identity map: the array index is the object id encoded in _OBJECTID.
                utf8JsonWriter.WriteStartObject("extras");
                utf8JsonWriter.WriteStartArray("objectMap");
                if (gLTFBatchEntries is not null)
                {
                    foreach (GLTFBatchEntry gLTFBatchEntry in gLTFBatchEntries)
                    {
                        utf8JsonWriter.WriteStartObject();
                        utf8JsonWriter.WriteString("reference", gLTFBatchEntry.Reference);
                        utf8JsonWriter.WriteString("name", gLTFBatchEntry.Name);
                        utf8JsonWriter.WriteNumber("batchIndex", gLTFBatchEntry.BatchIndex);
                        utf8JsonWriter.WriteNumber("vertexStart", gLTFBatchEntry.VertexStart);
                        utf8JsonWriter.WriteNumber("vertexCount", gLTFBatchEntry.VertexCount);
                        utf8JsonWriter.WriteNumber("indexStart", gLTFBatchEntry.IndexStart);
                        utf8JsonWriter.WriteNumber("indexCount", gLTFBatchEntry.IndexCount);
                        utf8JsonWriter.WritePropertyName("properties");
                        if (string.IsNullOrWhiteSpace(gLTFBatchEntry.Properties))
                        {
                            utf8JsonWriter.WriteNullValue();
                        }
                        else
                        {
                            utf8JsonWriter.WriteRawValue(gLTFBatchEntry.Properties, true);
                        }
                        utf8JsonWriter.WriteEndObject();
                    }
                }
                utf8JsonWriter.WriteEndArray();

                // The scene configuration (reference point, lights, camera) makes the GLB payload
                // fully self-describing so it can be streamed without a separate scene JSON. The
                // property shapes match the DiGi serialization (PascalCase, X/Y/Z, Red/Green/Blue).
                if (gLTFScene_Configuration is not null)
                {
                    WriteSceneConfiguration(utf8JsonWriter, gLTFScene_Configuration);
                }

                utf8JsonWriter.WriteEndObject();

                utf8JsonWriter.WriteEndObject();
                utf8JsonWriter.WriteEndArray();

                utf8JsonWriter.WriteNumber("scene", 0);

                utf8JsonWriter.WriteEndObject();
            }

            return memoryStream.ToArray();
        }

        private static void WriteSceneConfiguration(Utf8JsonWriter utf8JsonWriter, GLTFScene gLTFScene)
        {
            utf8JsonWriter.WriteStartObject("sceneConfiguration");

            if (gLTFScene.Name is not null)
            {
                utf8JsonWriter.WriteString("Name", gLTFScene.Name);
            }

            Geometry.Spatial.Classes.Point3D? referencePoint = gLTFScene.ReferencePoint;
            if (referencePoint is not null)
            {
                WriteCoordinate3D(utf8JsonWriter, "ReferencePoint", referencePoint.X, referencePoint.Y, referencePoint.Z);
            }

            List<GLTFLight>? gLTFLights = gLTFScene.Lights;
            if (gLTFLights is not null)
            {
                utf8JsonWriter.WriteStartArray("Lights");
                foreach (GLTFLight gLTFLight in gLTFLights)
                {
                    utf8JsonWriter.WriteStartObject();
                    utf8JsonWriter.WriteNumber("LightType", (int)gLTFLight.LightType);
                    utf8JsonWriter.WriteNumber("Intensity", gLTFLight.Intensity);

                    Core.Classes.Color? color = gLTFLight.Color;
                    if (color is not null)
                    {
                        utf8JsonWriter.WriteStartObject("Color");
                        utf8JsonWriter.WriteNumber("Red", color.Red);
                        utf8JsonWriter.WriteNumber("Green", color.Green);
                        utf8JsonWriter.WriteNumber("Blue", color.Blue);
                        utf8JsonWriter.WriteNumber("Alpha", color.Alpha);
                        utf8JsonWriter.WriteEndObject();
                    }

                    Geometry.Spatial.Classes.Vector3D? direction = gLTFLight.Direction;
                    if (direction is not null)
                    {
                        WriteCoordinate3D(utf8JsonWriter, "Direction", direction.X, direction.Y, direction.Z);
                    }

                    Geometry.Spatial.Classes.Point3D? position = gLTFLight.Position;
                    if (position is not null)
                    {
                        WriteCoordinate3D(utf8JsonWriter, "Position", position.X, position.Y, position.Z);
                    }

                    utf8JsonWriter.WriteEndObject();
                }
                utf8JsonWriter.WriteEndArray();
            }

            GLTFCamera? gLTFCamera = gLTFScene.Camera;
            if (gLTFCamera is not null)
            {
                utf8JsonWriter.WriteStartObject("Camera");
                utf8JsonWriter.WriteNumber("FieldOfView", gLTFCamera.FieldOfView);
                utf8JsonWriter.WriteBoolean("AutoFrame", gLTFCamera.AutoFrame);

                Geometry.Spatial.Classes.Point3D? position = gLTFCamera.Position;
                if (position is not null)
                {
                    WriteCoordinate3D(utf8JsonWriter, "Position", position.X, position.Y, position.Z);
                }

                Geometry.Spatial.Classes.Point3D? target = gLTFCamera.Target;
                if (target is not null)
                {
                    WriteCoordinate3D(utf8JsonWriter, "Target", target.X, target.Y, target.Z);
                }

                utf8JsonWriter.WriteEndObject();
            }

            utf8JsonWriter.WriteEndObject();
        }

        private static void WriteCoordinate3D(Utf8JsonWriter utf8JsonWriter, string propertyName, double x, double y, double z)
        {
            utf8JsonWriter.WriteStartObject(propertyName);
            utf8JsonWriter.WriteNumber("X", x);
            utf8JsonWriter.WriteNumber("Y", y);
            utf8JsonWriter.WriteNumber("Z", z);
            utf8JsonWriter.WriteEndObject();
        }

        private static void WriteBufferView(Utf8JsonWriter utf8JsonWriter, int byteOffset, int byteLength, int target)
        {
            utf8JsonWriter.WriteStartObject();
            utf8JsonWriter.WriteNumber("buffer", 0);
            utf8JsonWriter.WriteNumber("byteOffset", byteOffset);
            utf8JsonWriter.WriteNumber("byteLength", byteLength);
            utf8JsonWriter.WriteNumber("target", target);
            utf8JsonWriter.WriteEndObject();
        }

        private static void WriteUInt32(byte[] bytes, int offset, uint value)
        {
            // GLB is little-endian by specification.
            bytes[offset] = (byte)(value & 0xFF);
            bytes[offset + 1] = (byte)((value >> 8) & 0xFF);
            bytes[offset + 2] = (byte)((value >> 16) & 0xFF);
            bytes[offset + 3] = (byte)((value >> 24) & 0xFF);
        }
    }
}
