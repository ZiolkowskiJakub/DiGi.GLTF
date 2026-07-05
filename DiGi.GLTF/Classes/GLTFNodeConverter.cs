using DiGi.Core.Interfaces;
using DiGi.GLTF.Interfaces;
using System.Collections.Generic;

namespace DiGi.GLTF.Classes
{
    /// <summary>
    /// Convenience base class for <see cref="IGLTFNodeConverter"/> implementations handling a single domain type.
    /// <para>Derive from this class in the consuming project, implement <see cref="Convert(TSerializableObject, double)"/> and register the converter (see <see cref="Modify.Register(IGLTFNodeConverter?)"/>).</para>
    /// </summary>
    /// <typeparam name="TSerializableObject">The domain type handled by the converter.</typeparam>
    public abstract class GLTFNodeConverter<TSerializableObject> : IGLTFNodeConverter where TSerializableObject : ISerializableObject
    {
        /// <summary>
        /// Determines whether this converter can convert the specified object.
        /// </summary>
        /// <param name="serializableObject">The domain object to be checked.</param>
        /// <returns>True if the object is a <typeparamref name="TSerializableObject"/>; otherwise, false.</returns>
        public bool CanConvert(ISerializableObject serializableObject)
        {
            return serializableObject is TSerializableObject;
        }

        /// <summary>
        /// Converts the specified object into <see cref="GLTFNode"/> instances holding geometry in world coordinates.
        /// </summary>
        /// <param name="serializableObject">The domain object to be converted.</param>
        /// <param name="tolerance">The distance tolerance used during triangulation.</param>
        /// <returns>A list of <see cref="GLTFNode"/> instances, or null if the object cannot be converted.</returns>
        public List<GLTFNode>? Convert(ISerializableObject serializableObject, double tolerance)
        {
            if (serializableObject is not TSerializableObject serializableObject_Temp)
            {
                return null;
            }

            return Convert(serializableObject_Temp, tolerance);
        }

        /// <summary>
        /// Converts the specified <typeparamref name="TSerializableObject"/> into <see cref="GLTFNode"/> instances holding geometry in world coordinates.
        /// </summary>
        /// <param name="serializableObject">The domain object to be converted.</param>
        /// <param name="tolerance">The distance tolerance used during triangulation.</param>
        /// <returns>A list of <see cref="GLTFNode"/> instances, or null if the object cannot be converted.</returns>
        public abstract List<GLTFNode>? Convert(TSerializableObject serializableObject, double tolerance);
    }
}
