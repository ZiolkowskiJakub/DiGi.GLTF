using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.GLTF.Classes;
using System.Collections.Generic;

namespace DiGi.GLTF
{
    public static partial class Create
    {
        /// <summary>
        /// Merges the node geometry of the specified <see cref="Classes.GLTFScene"/> into a minimal set of <see cref="GLTFBatch"/> draw units (one opaque, one alpha-blended when required).
        /// <para>Per-object styling is baked into vertex colors and per-object identity is encoded as a per-vertex object id, so thousands of objects render with one or two WebGL draw calls while remaining individually selectable. Each object occupies a contiguous vertex and index range recorded in its <see cref="GLTFBatchEntry"/>.</para>
        /// </summary>
        /// <param name="gLTFScene">The <see cref="Classes.GLTFScene"/> to be batched. This value can be null.</param>
        /// <param name="gLTFBatchEntries">The identity entries of all batched objects; the list index of an entry is the object id encoded in the vertex attribute.</param>
        /// <returns>A list of <see cref="GLTFBatch"/> instances (opaque first, blended second when present), or null if the scene has no valid geometry.</returns>
        public static List<GLTFBatch>? GLTFBatches(this Classes.GLTFScene? gLTFScene, out List<GLTFBatchEntry> gLTFBatchEntries)
        {
            gLTFBatchEntries = [];

            List<GLTFNode>? gLTFNodes = gLTFScene?.Nodes_Direct;
            if (gLTFNodes is null || gLTFNodes.Count == 0)
            {
                return null;
            }

            // First pass: count vertices and triangles per alpha group to allocate exact buffers.
            int vertexCount_Opaque = 0;
            int triangleCount_Opaque = 0;
            int vertexCount_Blended = 0;
            int triangleCount_Blended = 0;

            List<Mesh3D> mesh3Ds = new(gLTFNodes.Count);
            List<GLTFNode> gLTFNodes_Valid = new(gLTFNodes.Count);
            List<bool> blendedFlags = new(gLTFNodes.Count);

            foreach (GLTFNode gLTFNode in gLTFNodes)
            {
                Mesh3D? mesh3D = gLTFNode?.Mesh3D_Direct;
                if (gLTFNode is null || mesh3D is null)
                {
                    continue;
                }

                int pointsCount = mesh3D.PointsCount;
                int trianglesCount = mesh3D.TrianglesCount;
                if (pointsCount <= 0 || trianglesCount <= 0)
                {
                    continue;
                }

                bool blended = gLTFNode.Opacity < 1;

                mesh3Ds.Add(mesh3D);
                gLTFNodes_Valid.Add(gLTFNode);
                blendedFlags.Add(blended);

                if (blended)
                {
                    vertexCount_Blended += pointsCount;
                    triangleCount_Blended += trianglesCount;
                }
                else
                {
                    vertexCount_Opaque += pointsCount;
                    triangleCount_Opaque += trianglesCount;
                }
            }

            if (gLTFNodes_Valid.Count == 0)
            {
                return null;
            }

            GLTFBatchBuilder? gLTFBatchBuilder_Opaque = vertexCount_Opaque == 0 ? null : new GLTFBatchBuilder(false, vertexCount_Opaque, triangleCount_Opaque);
            GLTFBatchBuilder? gLTFBatchBuilder_Blended = vertexCount_Blended == 0 ? null : new GLTFBatchBuilder(true, vertexCount_Blended, triangleCount_Blended);

            int batchIndex_Opaque = 0;
            int batchIndex_Blended = gLTFBatchBuilder_Opaque is null ? 0 : 1;

            // Second pass: pack positions, colors, object ids and indices into the contiguous buffers.
            for (int i = 0; i < gLTFNodes_Valid.Count; i++)
            {
                GLTFNode gLTFNode = gLTFNodes_Valid[i];
                Mesh3D mesh3D = mesh3Ds[i];
                bool blended = blendedFlags[i];

                GLTFBatchBuilder gLTFBatchBuilder = blended ? gLTFBatchBuilder_Blended! : gLTFBatchBuilder_Opaque!;

                int objectId = gLTFBatchEntries.Count;

                Color? color = gLTFNode.Color_Direct;
                byte red = color?.Red ?? byte.MaxValue;
                byte green = color?.Green ?? byte.MaxValue;
                byte blue = color?.Blue ?? byte.MaxValue;

                double opacity = gLTFNode.Opacity < 0 ? 0 : gLTFNode.Opacity > 1 ? 1 : gLTFNode.Opacity;
                byte alpha = (byte)System.Math.Round(opacity * (color?.Alpha ?? byte.MaxValue));

                int vertexStart = gLTFBatchBuilder.VertexCount;
                int indexStart = gLTFBatchBuilder.IndexCount;

                gLTFBatchBuilder.Add(mesh3D, objectId, red, green, blue, alpha);

                gLTFBatchEntries.Add(new GLTFBatchEntry(
                    gLTFNode.Reference,
                    gLTFNode.Name,
                    gLTFNode.Properties,
                    blended ? batchIndex_Blended : batchIndex_Opaque,
                    vertexStart,
                    gLTFBatchBuilder.VertexCount - vertexStart,
                    indexStart,
                    gLTFBatchBuilder.IndexCount - indexStart));
            }

            List<GLTFBatch> result = [];
            if (gLTFBatchBuilder_Opaque is not null)
            {
                result.Add(gLTFBatchBuilder_Opaque.ToGLTFBatch());
            }

            if (gLTFBatchBuilder_Blended is not null)
            {
                result.Add(gLTFBatchBuilder_Blended.ToGLTFBatch());
            }

            return result;
        }

        /// <summary>
        /// Accumulates packed vertex and index data for a single <see cref="GLTFBatch"/> using preallocated, exactly sized buffers.
        /// </summary>
        private sealed class GLTFBatchBuilder
        {
            private readonly bool blended;
            private readonly float[] positions;
            private readonly byte[] colors;
            private readonly float[] objectIds;
            private readonly int[] indexes;
            private readonly float[] min = [float.MaxValue, float.MaxValue, float.MaxValue];
            private readonly float[] max = [float.MinValue, float.MinValue, float.MinValue];

            private int vertexCount;
            private int indexCount;

            public GLTFBatchBuilder(bool blended, int vertexCapacity, int triangleCapacity)
            {
                this.blended = blended;
                positions = new float[vertexCapacity * 3];
                colors = new byte[vertexCapacity * 4];
                objectIds = new float[vertexCapacity];
                indexes = new int[triangleCapacity * 3];
            }

            public int IndexCount
            {
                get
                {
                    return indexCount;
                }
            }

            public int VertexCount
            {
                get
                {
                    return vertexCount;
                }
            }

            public void Add(Mesh3D mesh3D, int objectId, byte red, byte green, byte blue, byte alpha)
            {
                int vertexOffset = vertexCount;

                List<Point3D>? point3Ds = mesh3D.GetPoints();
                List<int[]>? triangleIndexes = mesh3D.GetIndexes();
                if (point3Ds is null || triangleIndexes is null)
                {
                    return;
                }

                float objectIdValue = objectId;

                for (int i = 0; i < point3Ds.Count; i++)
                {
                    Point3D point3D = point3Ds[i];

                    float x = (float)point3D.X;
                    float y = (float)point3D.Y;
                    float z = (float)point3D.Z;

                    int positionOffset = vertexCount * 3;
                    positions[positionOffset] = x;
                    positions[positionOffset + 1] = y;
                    positions[positionOffset + 2] = z;

                    if (x < min[0]) min[0] = x;
                    if (y < min[1]) min[1] = y;
                    if (z < min[2]) min[2] = z;
                    if (x > max[0]) max[0] = x;
                    if (y > max[1]) max[1] = y;
                    if (z > max[2]) max[2] = z;

                    int colorOffset = vertexCount * 4;
                    colors[colorOffset] = red;
                    colors[colorOffset + 1] = green;
                    colors[colorOffset + 2] = blue;
                    colors[colorOffset + 3] = alpha;

                    objectIds[vertexCount] = objectIdValue;

                    vertexCount++;
                }

                for (int i = 0; i < triangleIndexes.Count; i++)
                {
                    int[] triangle = triangleIndexes[i];
                    indexes[indexCount] = triangle[0] + vertexOffset;
                    indexes[indexCount + 1] = triangle[1] + vertexOffset;
                    indexes[indexCount + 2] = triangle[2] + vertexOffset;
                    indexCount += 3;
                }
            }

            public GLTFBatch ToGLTFBatch()
            {
                // The buffers were allocated from exact first-pass counts; trim defensively if a mesh was skipped.
                float[] positions_Result = positions;
                byte[] colors_Result = colors;
                float[] objectIds_Result = objectIds;
                int[] indexes_Result = indexes;

                if (vertexCount * 3 != positions.Length)
                {
                    positions_Result = new float[vertexCount * 3];
                    System.Array.Copy(positions, positions_Result, positions_Result.Length);

                    colors_Result = new byte[vertexCount * 4];
                    System.Array.Copy(colors, colors_Result, colors_Result.Length);

                    objectIds_Result = new float[vertexCount];
                    System.Array.Copy(objectIds, objectIds_Result, objectIds_Result.Length);
                }

                if (indexCount != indexes.Length)
                {
                    indexes_Result = new int[indexCount];
                    System.Array.Copy(indexes, indexes_Result, indexes_Result.Length);
                }

                return new GLTFBatch(blended, positions_Result, colors_Result, objectIds_Result, indexes_Result, min, max);
            }
        }
    }
}
