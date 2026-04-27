using DiGi.Geometry.Visual.Core.Interfaces;
using SharpGLTF.Materials;
using System.Numerics;

namespace DiGi.GLTF
{
    public static partial class Convert
    {
        public static MaterialBuilder? ToGLTF(this IAppearance appearance)
        {
            if (appearance is null)
            {
                return null;
            }

            float red = 1;
            float green = 1;
            float blue = 1;
            if (appearance.Color is Core.Classes.Color color)
            {
                red = color.Red / 255.0f;
                green = color.Green / 255.0f;
                blue = color.Blue / 255.0f;
            }

            Vector4 vector4 = new(red, green, blue, System.Convert.ToSingle(appearance.Opacity));

            AlphaMode alphaMode = appearance.Opacity == 0 ? AlphaMode.OPAQUE : AlphaMode.BLEND;

            MaterialBuilder result = new MaterialBuilder().WithDoubleSide(true).WithAlpha(alphaMode).WithBaseColor(vector4);

            return result;
        }
    }
}