using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.GLTF
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a triangulated <see cref="Mesh3D"/> from the specified <see cref="IGeometry3D"/>.
        /// <para>Supported geometry types: <see cref="Mesh3D"/>, <see cref="IPolygonalFace3D"/> (including <see cref="PolygonalFace3D"/>), <see cref="IPolygonal3D"/> (including <see cref="Polygon3D"/>), <see cref="PolygonalFaceExtrusion"/> and <see cref="Polyhedron"/>.</para>
        /// </summary>
        /// <param name="geometry3D">The <see cref="IGeometry3D"/> to be triangulated. This value can be null.</param>
        /// <param name="tolerance">The distance tolerance used during triangulation.</param>
        /// <returns>A <see cref="Mesh3D"/> representing the triangulated geometry, or null if the geometry is null or not supported.</returns>
        public static Mesh3D? Mesh3D(this IGeometry3D? geometry3D, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (geometry3D is null)
            {
                return null;
            }

            try
            {
                if (geometry3D is Mesh3D mesh3D)
                {
                    return new Mesh3D(mesh3D);
                }

                if (geometry3D is PolygonalFaceExtrusion polygonalFaceExtrusion)
                {
                    Polyhedron? polyhedron_Extrusion = Geometry.Spatial.Create.Polyhedron(polygonalFaceExtrusion, tolerance);
                    if (polyhedron_Extrusion is null)
                    {
                        return null;
                    }

                    return Geometry.Spatial.Create.Mesh3D(polyhedron_Extrusion, tolerance);
                }

                if (geometry3D is Polyhedron polyhedron)
                {
                    return Geometry.Spatial.Create.Mesh3D(polyhedron, tolerance);
                }

                if (geometry3D is IPolygonalFace3D polygonalFace3D)
                {
                    return Geometry.Spatial.Create.Mesh3D(polygonalFace3D, tolerance);
                }

                if (geometry3D is IPolygonal3D polygonal3D)
                {
                    return Geometry.Spatial.Create.Mesh3D(new PolygonalFace3D(polygonal3D), tolerance);
                }
            }
            catch (System.Exception)
            {
                return null;
            }

            return null;
        }
    }
}
