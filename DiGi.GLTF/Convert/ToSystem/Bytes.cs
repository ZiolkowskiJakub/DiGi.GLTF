using SharpGLTF.Scenes;

namespace DiGi.GLTF
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts the specified <see cref="SceneBuilder"/> instance into a byte array representing a binary glTF (.glb) file.
        /// </summary>
        /// <param name="sceneBuilder">The <see cref="SceneBuilder"/> instance to convert. This value can be null.</param>
        /// <returns>A byte array containing the GLB data if the conversion is successful and the input is not null; otherwise, null.</returns>
        public static byte[]? ToSystem_Bytes(this SceneBuilder? sceneBuilder)
        {
            if (sceneBuilder is null)
            {
                return null;
            }

            return sceneBuilder.ToGltf2()?.WriteGLB().ToArray();
        }
    }
}