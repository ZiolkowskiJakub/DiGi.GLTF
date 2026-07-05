using DiGi.Geometry.Spatial.Classes;
using DiGi.GLTF.Classes;
using System.Collections.Generic;

namespace DiGi.GLTF
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the axis-aligned bounding box of the geometry held by the specified <see cref="GLTFNode"/>.
        /// </summary>
        /// <param name="gLTFNode">The <see cref="GLTFNode"/> to be evaluated. This value can be null.</param>
        /// <returns>A <see cref="Geometry.Spatial.Classes.BoundingBox3D"/> of the node geometry, or null if the node or its mesh is null.</returns>
        public static BoundingBox3D? BoundingBox3D(this GLTFNode? gLTFNode)
        {
            return gLTFNode?.Mesh3D?.GetBoundingBox();
        }

        /// <summary>
        /// Calculates the combined axis-aligned bounding box of all <see cref="GLTFNode"/> geometry within the specified <see cref="GLTFScene"/>.
        /// <para>The bounding box is expressed in the local coordinates of the scene, relative to its reference point.</para>
        /// </summary>
        /// <param name="gLTFScene">The <see cref="GLTFScene"/> to be evaluated. This value can be null.</param>
        /// <returns>A <see cref="Geometry.Spatial.Classes.BoundingBox3D"/> covering all node geometry, or null if the scene has no valid geometry.</returns>
        public static BoundingBox3D? BoundingBox3D(this GLTFScene? gLTFScene)
        {
            List<GLTFNode>? gLTFNodes = gLTFScene?.Nodes;
            if (gLTFNodes is null)
            {
                return null;
            }

            BoundingBox3D? result = null;
            foreach (GLTFNode gLTFNode in gLTFNodes)
            {
                BoundingBox3D? boundingBox3D = BoundingBox3D(gLTFNode);
                if (boundingBox3D is null)
                {
                    continue;
                }

                if (result is null)
                {
                    result = boundingBox3D;
                }
                else
                {
                    result.Add(boundingBox3D);
                }
            }

            return result;
        }
    }
}
