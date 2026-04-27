using DiGi.Geometry.Spatial.Classes;
using SharpGLTF.Geometry.VertexTypes;

namespace DiGi.GLTF
{
    public static partial class Convert
    {
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