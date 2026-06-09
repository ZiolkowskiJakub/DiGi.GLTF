using DiGi.Geometry.Spatial.Classes;
using SharpGLTF.Geometry.VertexTypes;

namespace DiGi.GLTF
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Point3D"/> instance to a <see cref="VertexPosition"/>.
        /// </summary>
        /// <param name="point3D">The source <see cref="Point3D"/> to convert. This value can be null.</param>
        /// <returns>A <see cref="VertexPosition"/> representing the point in 3D space, or null if the provided <paramref name="point3D"/> is null.</returns>
        public static VertexPosition? ToGLTF(this Point3D? point3D)
        {
            if (point3D is null)
            {
                return null;
            }

            return new VertexPosition(System.Convert.ToSingle(point3D.X), System.Convert.ToSingle(point3D.Y), System.Convert.ToSingle(point3D.Z));
        }
    }
}