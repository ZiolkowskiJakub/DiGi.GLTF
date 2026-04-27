using DiGi.Geometry.Visual.Core.Interfaces;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Scenes;
using System.Numerics;

namespace DiGi.GLTF
{
    public static partial class Create
    {
        public static InstanceBuilder? InstanceBuilder(this SceneBuilder? sceneBuilder, IVisualObject? visualObject)
        {
            if (sceneBuilder is null || visualObject is null)
            {
                return null;
            }

            MeshBuilder<VertexPosition, VertexColor1>? meshBuilder = Convert.ToGLTF(visualObject);
            if (meshBuilder is null)
            {
                return null;
            }

            InstanceBuilder result = sceneBuilder.AddRigidMesh(meshBuilder, Matrix4x4.Identity);

            return result;
        }
    }
}