using DiGi.Geometry.Spatial.Classes;
using DiGi.GLTF.Classes;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Materials;
using SharpGLTF.Scenes;
using System.Collections.Generic;
using System.Numerics;

namespace DiGi.GLTF
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="GLTFScene"/> to a SharpGLTF <see cref="SceneBuilder"/>.
        /// <para>Each <see cref="GLTFNode"/> becomes a rigid mesh named after its reference. The serialized properties of the source object are attached as glTF extras so they can be displayed in a properties panel by the viewer.</para>
        /// </summary>
        /// <param name="gLTFScene">The <see cref="GLTFScene"/> to be converted. This value can be null.</param>
        /// <returns>A <see cref="SceneBuilder"/> holding the scene geometry, or null if <paramref name="gLTFScene"/> is null.</returns>
        public static SceneBuilder? ToGLTF(this GLTFScene? gLTFScene)
        {
            if (gLTFScene is null)
            {
                return null;
            }

            SceneBuilder result = new(gLTFScene.Name);

            List<GLTFNode>? gLTFNodes = gLTFScene.Nodes;
            if (gLTFNodes is not null)
            {
                foreach (GLTFNode gLTFNode in gLTFNodes)
                {
                    Mesh3D? mesh3D = gLTFNode.Mesh3D;
                    if (mesh3D is null)
                    {
                        continue;
                    }

                    MaterialBuilder materialBuilder = ToGLTF(gLTFNode.Color, gLTFNode.Opacity);

                    MeshBuilder<VertexPosition, VertexColor1> meshBuilder = new(gLTFNode.Reference ?? gLTFNode.Name);
                    Modify.Add(meshBuilder, mesh3D, materialBuilder);

                    // Extras must be structured JSON content (not a plain string) so glTF viewers expose it as userData.
                    string? properties = gLTFNode.Properties;
                    if (properties is not null)
                    {
                        meshBuilder.Extras = System.Text.Json.Nodes.JsonNode.Parse(properties);
                    }

                    result.AddRigidMesh(meshBuilder, Matrix4x4.Identity);
                }
            }

            return result;
        }
    }
}
