using System.ComponentModel;

namespace DiGi.GLTF.Enums
{
    /// <summary>
    /// Defines the type of a light source within a GLTF scene.
    /// </summary>
    [Description("Light type")]
    public enum LightType
    {
        /// <summary>
        /// Undefined light type.
        /// </summary>
        [Description("Undefined")]
        Undefined,

        /// <summary>
        /// Ambient light illuminating all objects equally from all directions.
        /// </summary>
        [Description("Ambient")]
        Ambient,

        /// <summary>
        /// Directional light with parallel rays, such as the sun.
        /// </summary>
        [Description("Directional")]
        Directional,

        /// <summary>
        /// Point light emitting in all directions from a single position.
        /// </summary>
        [Description("Point")]
        Point
    }
}
