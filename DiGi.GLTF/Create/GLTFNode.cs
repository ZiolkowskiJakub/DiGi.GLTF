using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.GLTF.Classes;

namespace DiGi.GLTF
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="GLTFNode"/> from the specified <see cref="IGeometry3D"/> by triangulating the geometry and applying the given styling.
        /// </summary>
        /// <param name="geometry3D">The <see cref="IGeometry3D"/> to be converted. This value can be null.</param>
        /// <param name="name">The display name of the node.</param>
        /// <param name="reference">The unique reference identifying the source object of the node.</param>
        /// <param name="color">The <see cref="Color"/> used to render the node. If this value is null, the default color is used.</param>
        /// <param name="opacity">The opacity of the node where 1 is fully opaque and 0 is fully transparent.</param>
        /// <param name="properties">The JSON string with the properties of the source object. This value can be null.</param>
        /// <param name="tolerance">The distance tolerance used during triangulation.</param>
        /// <returns>A <see cref="GLTFNode"/> holding the triangulated geometry, or null if the geometry is null or not supported.</returns>
        public static GLTFNode? GLTFNode(this IGeometry3D? geometry3D, string? name = null, string? reference = null, Color? color = null, double opacity = 1, string? properties = null, double tolerance = Core.Constants.Tolerance.Distance)
        {
            Mesh3D? mesh3D = Mesh3D(geometry3D, tolerance);
            if (mesh3D is null)
            {
                return null;
            }

            Color color_Temp = color ?? new Color(byte.MaxValue, 210, 210, 215);

            return new GLTFNode(name, reference, mesh3D, color_Temp, opacity, properties);
        }
    }
}
