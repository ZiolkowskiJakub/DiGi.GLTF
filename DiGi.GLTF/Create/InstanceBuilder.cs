using DiGi.Geometry.Visual.Core.Interfaces;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Scenes;
using System.Numerics;

namespace DiGi.GLTF
{
    public static partial class Create
    {
        /// <summary>
        /// Creates an <see cref="InstanceBuilder"/> by converting a visual object to a GLTF mesh and adding it to the provided scene builder.
        /// </summary>
        /// <param name="sceneBuilder">The <see cref="SceneBuilder"/> used to create the instance. This parameter can be null.</param>
        /// <param name="visualObject">The <see cref="IVisualObject"/> to be converted into a GLTF mesh and instanced. This parameter can be null.</param>
        /// <returns>An <see cref="InstanceBuilder"/> representing the created instance in the scene, or null if either the <paramref name="sceneBuilder"/> or <paramref name="visualObject"/> is null, or if the conversion to a GLTF mesh fails.</returns>
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