using DiGi.Core.Interfaces;
using DiGi.GLTF.Classes;
using System.Collections.Generic;

namespace DiGi.GLTF.Interfaces
{
    /// <summary>
    /// Defines a pluggable converter turning a domain <see cref="ISerializableObject"/> into generic <see cref="GLTFNode"/> instances.
    /// <para>Converters are registered with <see cref="Modify.Register(IGLTFNodeConverter?)"/> (or via assembly scanning) and are consulted by <see cref="Convert.ToGLTF_GLTFNodes(ISerializableObject?, double)"/>. This keeps the engine open for extension and closed for modification: supporting a new domain type only requires a new converter class in the consuming project.</para>
    /// </summary>
    public interface IGLTFNodeConverter : IGLTFObject
    {
        /// <summary>
        /// Determines whether this converter can convert the specified object.
        /// </summary>
        /// <param name="serializableObject">The domain object to be checked.</param>
        /// <returns>True if this converter handles the object; otherwise, false.</returns>
        bool CanConvert(ISerializableObject serializableObject);

        /// <summary>
        /// Converts the specified object into <see cref="GLTFNode"/> instances holding geometry in world coordinates.
        /// </summary>
        /// <param name="serializableObject">The domain object to be converted.</param>
        /// <param name="tolerance">The distance tolerance used during triangulation.</param>
        /// <returns>A list of <see cref="GLTFNode"/> instances, or null if the object cannot be converted.</returns>
        List<GLTFNode>? Convert(ISerializableObject serializableObject, double tolerance);
    }
}
