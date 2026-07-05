using DiGi.Core.Classes;
using DiGi.GLTF.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GLTF.Classes
{
    /// <summary>
    /// Represents a model holding multiple <see cref="GLTFScene"/> instances together with general model properties.
    /// </summary>
    public class GLTFModel : SerializableObject, IGLTFSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name;

        [JsonInclude, JsonPropertyName(nameof(Description))]
        private readonly string? description;

        [JsonInclude, JsonPropertyName(nameof(Scenes))]
        private readonly List<GLTFScene>? scenes;

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFModel"/> class.
        /// </summary>
        /// <param name="name">The display name of the model.</param>
        /// <param name="description">The description of the model.</param>
        /// <param name="scenes">The <see cref="GLTFScene"/> instances contained in the model. This value can be null.</param>
        public GLTFModel(string? name, string? description, IEnumerable<GLTFScene>? scenes)
        {
            this.name = name;
            this.description = description;

            if (scenes != null)
            {
                this.scenes = [];
                foreach (GLTFScene gLTFScene in scenes)
                {
                    if (DiGi.Core.Query.Clone(gLTFScene) is GLTFScene gLTFScene_Temp)
                    {
                        this.scenes.Add(gLTFScene_Temp);
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFModel"/> class by copying an existing <see cref="GLTFModel"/> instance.
        /// </summary>
        /// <param name="gLTFModel">The <see cref="GLTFModel"/> instance to copy from. This value can be null.</param>
        public GLTFModel(GLTFModel? gLTFModel)
            : base(gLTFModel)
        {
            if (gLTFModel != null)
            {
                name = gLTFModel.name;
                description = gLTFModel.description;

                if (gLTFModel.scenes != null)
                {
                    scenes = [];
                    foreach (GLTFScene gLTFScene in gLTFModel.scenes)
                    {
                        if (DiGi.Core.Query.Clone(gLTFScene) is GLTFScene gLTFScene_Temp)
                        {
                            scenes.Add(gLTFScene_Temp);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFModel"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the model. This value can be null.</param>
        public GLTFModel(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the description of the model.
        /// </summary>
        [JsonIgnore]
        public string? Description
        {
            get
            {
                return description;
            }
        }

        /// <summary>
        /// Gets the display name of the model.
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
        /// Gets the <see cref="GLTFScene"/> instances contained in the model.
        /// </summary>
        [JsonIgnore]
        public List<GLTFScene>? Scenes
        {
            get
            {
                if (scenes == null)
                {
                    return null;
                }

                List<GLTFScene> result = [];
                foreach (GLTFScene gLTFScene in scenes)
                {
                    if (DiGi.Core.Query.Clone(gLTFScene) is GLTFScene gLTFScene_Temp)
                    {
                        result.Add(gLTFScene_Temp);
                    }
                }

                return result;
            }
        }
    }
}
