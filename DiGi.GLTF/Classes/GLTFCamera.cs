using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.GLTF.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GLTF.Classes
{
    /// <summary>
    /// Represents a camera within a <see cref="GLTFScene"/>, defined by its position, target, field of view and automatic framing behavior.
    /// </summary>
    public class GLTFCamera : SerializableObject, IGLTFSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name;

        [JsonInclude, JsonPropertyName(nameof(Position))]
        private readonly Point3D? position;

        [JsonInclude, JsonPropertyName(nameof(Target))]
        private readonly Point3D? target;

        [JsonInclude, JsonPropertyName(nameof(FieldOfView))]
        private readonly double fieldOfView = 50;

        [JsonInclude, JsonPropertyName(nameof(AutoFrame))]
        private readonly bool autoFrame = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFCamera"/> class.
        /// </summary>
        /// <param name="name">The display name of the camera.</param>
        /// <param name="position">The <see cref="Point3D"/> position of the camera. This value can be null when <paramref name="autoFrame"/> is true.</param>
        /// <param name="target">The <see cref="Point3D"/> the camera looks at. This value can be null when <paramref name="autoFrame"/> is true.</param>
        /// <param name="fieldOfView">The vertical field of view in degrees.</param>
        /// <param name="autoFrame">A value indicating whether the camera automatically frames the whole scene bounding box on load.</param>
        public GLTFCamera(string? name, Point3D? position, Point3D? target, double fieldOfView, bool autoFrame)
        {
            this.name = name;
            this.position = Core.Query.Clone(position);
            this.target = Core.Query.Clone(target);
            this.fieldOfView = fieldOfView;
            this.autoFrame = autoFrame;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFCamera"/> class by copying an existing <see cref="GLTFCamera"/> instance.
        /// </summary>
        /// <param name="gLTFCamera">The <see cref="GLTFCamera"/> instance to copy from. This value can be null.</param>
        public GLTFCamera(GLTFCamera? gLTFCamera)
            : base(gLTFCamera)
        {
            if (gLTFCamera != null)
            {
                name = gLTFCamera.name;
                position = Core.Query.Clone(gLTFCamera.position);
                target = Core.Query.Clone(gLTFCamera.target);
                fieldOfView = gLTFCamera.fieldOfView;
                autoFrame = gLTFCamera.autoFrame;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFCamera"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the camera. This value can be null.</param>
        public GLTFCamera(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets a value indicating whether the camera automatically frames the whole scene bounding box on load.
        /// </summary>
        [JsonIgnore]
        public bool AutoFrame
        {
            get
            {
                return autoFrame;
            }
        }

        /// <summary>
        /// Gets the vertical field of view in degrees.
        /// </summary>
        [JsonIgnore]
        public double FieldOfView
        {
            get
            {
                return fieldOfView;
            }
        }

        /// <summary>
        /// Gets the display name of the camera.
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
        /// Gets the <see cref="Point3D"/> position of the camera.
        /// </summary>
        [JsonIgnore]
        public Point3D? Position
        {
            get
            {
                return Core.Query.Clone(position);
            }
        }

        /// <summary>
        /// Gets the <see cref="Point3D"/> the camera looks at.
        /// </summary>
        [JsonIgnore]
        public Point3D? Target
        {
            get
            {
                return Core.Query.Clone(target);
            }
        }
    }
}
