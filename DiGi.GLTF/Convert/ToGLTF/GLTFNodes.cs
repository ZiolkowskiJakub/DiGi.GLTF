using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.GLTF.Classes;
using DiGi.GLTF.Interfaces;
using System.Collections.Generic;

namespace DiGi.GLTF
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts the specified <see cref="ISerializableObject"/> into <see cref="GLTFNode"/> instances holding geometry in world coordinates.
        /// <para>The registered <see cref="IGLTFNodeConverter"/> instances are consulted first (in registration order), keeping the engine open for extension: consuming projects plug in converters for their domain types without modifying this method. Built-in fallbacks handle <see cref="GLTFNode"/> pass-through and raw <see cref="IGeometry3D"/> geometry.</para>
        /// </summary>
        /// <param name="serializableObject">The object to be converted. This value can be null.</param>
        /// <param name="tolerance">The distance tolerance used during triangulation.</param>
        /// <returns>A list of <see cref="GLTFNode"/> instances, or null if the object is null or no converter handles it.</returns>
        public static List<GLTFNode>? ToGLTF_GLTFNodes(this ISerializableObject? serializableObject, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (serializableObject is null)
            {
                return null;
            }

            List<IGLTFNodeConverter> gLTFNodeConverters = Modify.RegisteredGLTFNodeConverters();
            foreach (IGLTFNodeConverter gLTFNodeConverter in gLTFNodeConverters)
            {
                if (gLTFNodeConverter.CanConvert(serializableObject))
                {
                    return gLTFNodeConverter.Convert(serializableObject, tolerance);
                }
            }

            if (serializableObject is GLTFNode gLTFNode)
            {
                return [new GLTFNode(gLTFNode)];
            }

            if (serializableObject is IGeometry3D geometry3D)
            {
                GLTFNode? gLTFNode_Geometry = Create.GLTFNode(geometry3D, serializableObject.GetType().Name, Core.Create.UniqueReference(serializableObject)?.ToString(), null, 1, serializableObject.ToSystem_String(), tolerance);
                return gLTFNode_Geometry is null ? null : [gLTFNode_Geometry];
            }

            return null;
        }
    }
}
