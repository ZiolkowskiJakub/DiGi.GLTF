using SharpGLTF.Scenes;

namespace DiGi.GLTF
{
    public static partial class Convert
    {
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