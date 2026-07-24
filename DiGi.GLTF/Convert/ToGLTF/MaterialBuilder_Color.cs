using SharpGLTF.Materials;
using System.Numerics;

namespace DiGi.GLTF
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Core.Classes.Color"/> and opacity to a SharpGLTF <see cref="MaterialBuilder"/>.
        /// </summary>
        /// <param name="color">The <see cref="Core.Classes.Color"/> used as the base color of the material. If this value is null, white is used.</param>
        /// <param name="opacity">The opacity of the material where 1 is fully opaque and 0 is fully transparent.</param>
        /// <returns>A double-sided <see cref="MaterialBuilder"/> with the given base color and alpha mode derived from the opacity.</returns>
        public static MaterialBuilder ToGLTF(this Core.Classes.Color? color, double opacity = 1)
        {
            float red = 1;
            float green = 1;
            float blue = 1;
            if (color is not null)
            {
                red = color.Red / 255.0f;
                green = color.Green / 255.0f;
                blue = color.Blue / 255.0f;
            }

            Vector4 vector4 = new(red, green, blue, System.Convert.ToSingle(opacity));

            AlphaMode alphaMode = opacity < 1 ? AlphaMode.BLEND : AlphaMode.OPAQUE;

            MaterialBuilder result = new MaterialBuilder().WithDoubleSide(true).WithAlpha(alphaMode).WithBaseColor(vector4);

            return result;
        }
    }
}
