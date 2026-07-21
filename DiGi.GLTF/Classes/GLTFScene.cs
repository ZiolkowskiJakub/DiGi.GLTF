using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.GLTF.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GLTF.Classes
{
    /// <summary>
    /// Represents a renderable scene holding <see cref="GLTFNode"/> objects, light configuration and camera position.
    /// <para>All node geometry is expressed in local coordinates around the origin (0, 0, 0). The original world offset removed from the geometry is stored in <see cref="ReferencePoint"/> to avoid floating-point precision issues in WebGL rendering of GIS coordinates.</para>
    /// </summary>
    public class GLTFScene : SerializableObject, IGLTFSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name;

        [JsonInclude, JsonPropertyName(nameof(ReferencePoint))]
        private readonly Point3D? referencePoint;

        [JsonInclude, JsonPropertyName(nameof(Nodes))]
        private readonly List<GLTFNode>? nodes;

        [JsonInclude, JsonPropertyName(nameof(Lights))]
        private readonly List<GLTFLight>? lights;

        [JsonInclude, JsonPropertyName(nameof(Camera))]
        private readonly GLTFCamera? camera;

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFScene"/> class.
        /// </summary>
        /// <param name="name">The display name of the scene.</param>
        /// <param name="referencePoint">The <see cref="Point3D"/> world offset removed from the node geometry during conversion to local coordinates. This value can be null.</param>
        /// <param name="nodes">The <see cref="GLTFNode"/> objects to be displayed. This value can be null.</param>
        /// <param name="lights">The <see cref="GLTFLight"/> configuration of the scene. This value can be null.</param>
        /// <param name="camera">The <see cref="GLTFCamera"/> of the scene. This value can be null.</param>
        public GLTFScene(string? name, Point3D? referencePoint, IEnumerable<GLTFNode>? nodes, IEnumerable<GLTFLight>? lights, GLTFCamera? camera)
        {
            this.name = name;
            this.referencePoint = Core.Query.Clone(referencePoint);

            if (nodes != null)
            {
                this.nodes = [];
                foreach (GLTFNode gLTFNode in nodes)
                {
                    if (Core.Query.Clone(gLTFNode) is GLTFNode gLTFNode_Temp)
                    {
                        this.nodes.Add(gLTFNode_Temp);
                    }
                }
            }

            if (lights != null)
            {
                this.lights = [];
                foreach (GLTFLight gLTFLight in lights)
                {
                    if (Core.Query.Clone(gLTFLight) is GLTFLight gLTFLight_Temp)
                    {
                        this.lights.Add(gLTFLight_Temp);
                    }
                }
            }

            this.camera = Core.Query.Clone(camera);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFScene"/> class adopting the given instances without cloning.
        /// <para>Performance path for large scene generation: the caller transfers ownership of all provided instances and must not mutate them afterwards.</para>
        /// </summary>
        /// <param name="adopt">Signature discriminator; always pass true.</param>
        /// <param name="name">The display name of the scene.</param>
        /// <param name="referencePoint">The <see cref="Point3D"/> world offset adopted by the scene. This value can be null.</param>
        /// <param name="nodes">The <see cref="GLTFNode"/> list adopted by the scene. This value can be null.</param>
        /// <param name="lights">The <see cref="GLTFLight"/> list adopted by the scene. This value can be null.</param>
        /// <param name="camera">The <see cref="GLTFCamera"/> adopted by the scene. This value can be null.</param>
        internal GLTFScene(bool adopt, string? name, Point3D? referencePoint, List<GLTFNode>? nodes, List<GLTFLight>? lights, GLTFCamera? camera)
        {
            this.name = name;
            this.referencePoint = referencePoint;
            this.nodes = nodes;
            this.lights = lights;
            this.camera = camera;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFScene"/> class by copying an existing <see cref="GLTFScene"/> instance.
        /// </summary>
        /// <param name="gLTFScene">The <see cref="GLTFScene"/> instance to copy from. This value can be null.</param>
        public GLTFScene(GLTFScene? gLTFScene)
            : base(gLTFScene)
        {
            if (gLTFScene != null)
            {
                name = gLTFScene.name;
                referencePoint = Core.Query.Clone(gLTFScene.referencePoint);

                if (gLTFScene.nodes != null)
                {
                    nodes = [];
                    foreach (GLTFNode gLTFNode in gLTFScene.nodes)
                    {
                        if (Core.Query.Clone(gLTFNode) is GLTFNode gLTFNode_Temp)
                        {
                            nodes.Add(gLTFNode_Temp);
                        }
                    }
                }

                if (gLTFScene.lights != null)
                {
                    lights = [];
                    foreach (GLTFLight gLTFLight in gLTFScene.lights)
                    {
                        if (Core.Query.Clone(gLTFLight) is GLTFLight gLTFLight_Temp)
                        {
                            lights.Add(gLTFLight_Temp);
                        }
                    }
                }

                camera = Core.Query.Clone(gLTFScene.camera);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFScene"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the scene. This value can be null.</param>
        public GLTFScene(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the <see cref="GLTFCamera"/> of the scene.
        /// </summary>
        [JsonIgnore]
        public GLTFCamera? Camera
        {
            get
            {
                return Core.Query.Clone(camera);
            }
        }

        /// <summary>
        /// Gets the <see cref="GLTFLight"/> configuration of the scene.
        /// </summary>
        [JsonIgnore]
        public List<GLTFLight>? Lights
        {
            get
            {
                if (lights == null)
                {
                    return null;
                }

                List<GLTFLight> result = [];
                foreach (GLTFLight gLTFLight in lights)
                {
                    if (Core.Query.Clone(gLTFLight) is GLTFLight gLTFLight_Temp)
                    {
                        result.Add(gLTFLight_Temp);
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// Gets the display name of the scene.
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
        /// Gets the <see cref="GLTFNode"/> objects to be displayed.
        /// </summary>
        [JsonIgnore]
        public List<GLTFNode>? Nodes
        {
            get
            {
                if (nodes == null)
                {
                    return null;
                }

                List<GLTFNode> result = [];
                foreach (GLTFNode gLTFNode in nodes)
                {
                    if (Core.Query.Clone(gLTFNode) is GLTFNode gLTFNode_Temp)
                    {
                        result.Add(gLTFNode_Temp);
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// Gets the <see cref="Point3D"/> world offset removed from the node geometry during conversion to local coordinates.
        /// </summary>
        [JsonIgnore]
        public Point3D? ReferencePoint
        {
            get
            {
                return Core.Query.Clone(referencePoint);
            }
        }

        /// <summary>
        /// Gets the <see cref="GLTFNode"/> list of the scene without cloning.
        /// <para>Performance path for large scene generation: the returned list and its items must not be mutated.</para>
        /// </summary>
        [JsonIgnore]
        internal List<GLTFNode>? Nodes_Direct
        {
            get
            {
                return nodes;
            }
        }
    }
}
