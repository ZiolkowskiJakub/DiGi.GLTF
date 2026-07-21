using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.GLTF.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GLTF.Classes
{
    /// <summary>
    /// Represents a single displayable and selectable object within a <see cref="GLTFScene"/>, holding triangulated geometry, styling and the serialized properties of the source object.
    /// </summary>
    public class GLTFNode : SerializableObject, IGLTFSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name;

        [JsonInclude, JsonPropertyName(nameof(Reference))]
        private readonly string? reference;

        [JsonInclude, JsonPropertyName(nameof(Mesh3D))]
        private readonly Mesh3D? mesh3D;

        [JsonInclude, JsonPropertyName(nameof(Color))]
        private readonly Color? color;

        [JsonInclude, JsonPropertyName(nameof(Opacity))]
        private readonly double opacity = 1;

        [JsonInclude, JsonPropertyName(nameof(Properties))]
        private readonly string? properties;

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFNode"/> class.
        /// </summary>
        /// <param name="name">The display name of the node.</param>
        /// <param name="reference">The unique reference identifying the source object of the node.</param>
        /// <param name="mesh3D">The triangulated <see cref="Mesh3D"/> geometry of the node. This value can be null.</param>
        /// <param name="color">The <see cref="Color"/> used to render the node. This value can be null.</param>
        /// <param name="opacity">The opacity of the node where 1 is fully opaque and 0 is fully transparent.</param>
        /// <param name="properties">The JSON string with the properties of the source object displayed in the properties panel. This value can be null.</param>
        public GLTFNode(string? name, string? reference, Mesh3D? mesh3D, Color? color, double opacity, string? properties)
        {
            this.name = name;
            this.reference = reference;
            this.mesh3D = Core.Query.Clone(mesh3D);
            this.color = Core.Query.Clone(color);
            this.opacity = opacity;
            this.properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFNode"/> class adopting the given instances without cloning.
        /// <para>Performance path for large scene generation: the caller transfers ownership of <paramref name="mesh3D"/> and <paramref name="color"/> and must not mutate them afterwards.</para>
        /// </summary>
        /// <param name="adopt">Signature discriminator; always pass true.</param>
        /// <param name="name">The display name of the node.</param>
        /// <param name="reference">The unique reference identifying the source object of the node.</param>
        /// <param name="mesh3D">The triangulated <see cref="Geometry.Spatial.Classes.Mesh3D"/> geometry adopted by the node. This value can be null.</param>
        /// <param name="color">The <see cref="Core.Classes.Color"/> adopted by the node. This value can be null.</param>
        /// <param name="opacity">The opacity of the node where 1 is fully opaque and 0 is fully transparent.</param>
        /// <param name="properties">The JSON string with the properties of the source object. This value can be null.</param>
        internal GLTFNode(bool adopt, string? name, string? reference, Mesh3D? mesh3D, Color? color, double opacity, string? properties)
        {
            this.name = name;
            this.reference = reference;
            this.mesh3D = mesh3D;
            this.color = color;
            this.opacity = opacity;
            this.properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFNode"/> class by copying an existing <see cref="GLTFNode"/> instance.
        /// </summary>
        /// <param name="gLTFNode">The <see cref="GLTFNode"/> instance to copy from. This value can be null.</param>
        public GLTFNode(GLTFNode? gLTFNode)
            : base(gLTFNode)
        {
            if (gLTFNode != null)
            {
                name = gLTFNode.name;
                reference = gLTFNode.reference;
                mesh3D = Core.Query.Clone(gLTFNode.mesh3D);
                color = Core.Query.Clone(gLTFNode.color);
                opacity = gLTFNode.opacity;
                properties = gLTFNode.properties;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFNode"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the node. This value can be null.</param>
        public GLTFNode(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the <see cref="Color"/> used to render the node.
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
        /// Gets the triangulated <see cref="Mesh3D"/> geometry of the node.
        /// </summary>
        [JsonIgnore]
        public Mesh3D? Mesh3D
        {
            get
            {
                return Core.Query.Clone(mesh3D);
            }
        }

        /// <summary>
        /// Gets the triangulated <see cref="Geometry.Spatial.Classes.Mesh3D"/> geometry of the node without cloning.
        /// <para>Performance path for large scene generation: the returned instance must not be mutated.</para>
        /// </summary>
        [JsonIgnore]
        internal Mesh3D? Mesh3D_Direct
        {
            get
            {
                return mesh3D;
            }
        }

        /// <summary>
        /// Gets the <see cref="Core.Classes.Color"/> of the node without cloning.
        /// <para>Performance path for large scene generation: the returned instance must not be mutated.</para>
        /// </summary>
        [JsonIgnore]
        internal Color? Color_Direct
        {
            get
            {
                return color;
            }
        }

        /// <summary>
        /// Gets the display name of the node.
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
        /// Gets the opacity of the node where 1 is fully opaque and 0 is fully transparent.
        /// </summary>
        [JsonIgnore]
        public double Opacity
        {
            get
            {
                return opacity;
            }
        }

        /// <summary>
        /// Gets the JSON string with the properties of the source object displayed in the properties panel.
        /// </summary>
        [JsonIgnore]
        public string? Properties
        {
            get
            {
                return properties;
            }
        }

        /// <summary>
        /// Gets the unique reference identifying the source object of the node.
        /// </summary>
        [JsonIgnore]
        public string? Reference
        {
            get
            {
                return reference;
            }
        }
    }
}
