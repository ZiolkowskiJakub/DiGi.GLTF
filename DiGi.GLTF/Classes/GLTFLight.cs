using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.GLTF.Enums;
using DiGi.GLTF.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GLTF.Classes
{
    /// <summary>
    /// Represents a light source within a <see cref="GLTFScene"/>, defined by its type, color, intensity, direction and position.
    /// </summary>
    public class GLTFLight : SerializableObject, IGLTFSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name;

        [JsonInclude, JsonPropertyName(nameof(LightType))]
        private readonly LightType lightType = LightType.Undefined;

        [JsonInclude, JsonPropertyName(nameof(Color))]
        private readonly Color? color;

        [JsonInclude, JsonPropertyName(nameof(Intensity))]
        private readonly double intensity = 1;

        [JsonInclude, JsonPropertyName(nameof(Direction))]
        private readonly Vector3D? direction;

        [JsonInclude, JsonPropertyName(nameof(Position))]
        private readonly Point3D? position;

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFLight"/> class.
        /// </summary>
        /// <param name="name">The display name of the light.</param>
        /// <param name="lightType">The <see cref="Enums.LightType"/> of the light.</param>
        /// <param name="color">The <see cref="Color"/> of the emitted light. This value can be null.</param>
        /// <param name="intensity">The intensity of the light where 1 is the default full intensity.</param>
        /// <param name="direction">The <see cref="Vector3D"/> direction of the light rays for directional lights. This value can be null.</param>
        /// <param name="position">The <see cref="Point3D"/> position of the light for point lights. This value can be null.</param>
        public GLTFLight(string? name, LightType lightType, Color? color, double intensity, Vector3D? direction, Point3D? position)
        {
            this.name = name;
            this.lightType = lightType;
            this.color = Core.Query.Clone(color);
            this.intensity = intensity;
            this.direction = Core.Query.Clone(direction);
            this.position = Core.Query.Clone(position);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFLight"/> class by copying an existing <see cref="GLTFLight"/> instance.
        /// </summary>
        /// <param name="gLTFLight">The <see cref="GLTFLight"/> instance to copy from. This value can be null.</param>
        public GLTFLight(GLTFLight? gLTFLight)
            : base(gLTFLight)
        {
            if (gLTFLight != null)
            {
                name = gLTFLight.name;
                lightType = gLTFLight.lightType;
                color = Core.Query.Clone(gLTFLight.color);
                intensity = gLTFLight.intensity;
                direction = Core.Query.Clone(gLTFLight.direction);
                position = Core.Query.Clone(gLTFLight.position);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFLight"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the light. This value can be null.</param>
        public GLTFLight(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the <see cref="Color"/> of the emitted light.
        /// </summary>
        [JsonIgnore]
        public Color? Color
        {
            get
            {
                return Core.Query.Clone(color);
            }
        }

        /// <summary>
        /// Gets the <see cref="Vector3D"/> direction of the light rays for directional lights.
        /// </summary>
        [JsonIgnore]
        public Vector3D? Direction
        {
            get
            {
                return Core.Query.Clone(direction);
            }
        }

        /// <summary>
        /// Gets the intensity of the light where 1 is the default full intensity.
        /// </summary>
        [JsonIgnore]
        public double Intensity
        {
            get
            {
                return intensity;
            }
        }

        /// <summary>
        /// Gets the <see cref="Enums.LightType"/> of the light.
        /// </summary>
        [JsonIgnore]
        public LightType LightType
        {
            get
            {
                return lightType;
            }
        }

        /// <summary>
        /// Gets the display name of the light.
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Gets the <see cref="Point3D"/> position of the light for point lights.
        /// </summary>
        [JsonIgnore]
        public Point3D? Position
        {
            get
            {
                return Core.Query.Clone(position);
            }
        }
    }
}
