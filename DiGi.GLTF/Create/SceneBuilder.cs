using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Scenes;
using System.Collections.Generic;
using System.Numerics;

namespace DiGi.GLTF
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="SceneBuilder"/> and populates it by adding the provided collection of mesh builders as rigid meshes with identity transforms.
        /// </summary>
        /// <param name="meshBuilders">The enumerable collection of <see cref="MeshBuilder{VertexPosition, VertexColor1}"/> to be added to the scene. This parameter can be null.</param>
        /// <returns>A new instance of <see cref="SceneBuilder"/> containing the provided meshes; returns an empty <see cref="SceneBuilder"/> if <paramref name="meshBuilders"/> is null.</returns>
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