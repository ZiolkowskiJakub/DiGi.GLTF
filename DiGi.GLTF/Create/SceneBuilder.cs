using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Scenes;
using System.Collections.Generic;
using System.Numerics;

namespace DiGi.GLTF
{
    public static partial class Create
    {
        public static SceneBuilder? SceneBuilder(this IEnumerable<MeshBuilder<VertexPosition, VertexColor1>> meshBuilders)
        {
            SceneBuilder result = new();

            if (meshBuilders != null)
            {
                foreach (MeshBuilder<VertexPosition, VertexColor1> meshBuilder in meshBuilders)
                {
                    result.AddRigidMesh(meshBuilder, Matrix4x4.Identity);
                }
            }

            return result;
        }
    }
}