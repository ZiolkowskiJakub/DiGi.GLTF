using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.GLTF.Classes;
using DiGi.GLTF.Enums;
using System.Collections.Generic;

namespace DiGi.GLTF
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.GLTFScene"/> from the specified <see cref="GLTFNode"/> instances by translating all geometry to a local origin (0, 0, 0).
        /// <para>The reference point removed from the geometry is calculated from the combined bounding box (its centroid in X and Y, its minimum in Z) and stored in <see cref="GLTFScene.ReferencePoint"/> so the original world coordinates can be restored. This avoids floating-point precision issues in WebGL rendering of large GIS coordinates.</para>
        /// </summary>
        /// <param name="gLTFNodes">The <see cref="GLTFNode"/> instances holding geometry in world coordinates. This value can be null.</param>
        /// <param name="name">The display name of the scene.</param>
        /// <param name="gLTFLights">The <see cref="GLTFLight"/> configuration of the scene. If this value is null, default lighting (ambient light and directional sun light) is created.</param>
        /// <param name="gLTFCamera">The <see cref="GLTFCamera"/> of the scene. If this value is null, a default automatically framing camera is created.</param>
        /// <param name="referencePointOverride">When non-null, the <see cref="Point3D"/> whose X and Y replace the bounding-box centroid coordinates in the computed <see cref="GLTFScene.ReferencePoint"/> (the Z component still comes from the bounding box minimum Z).</param>
        /// <returns>A <see cref="Classes.GLTFScene"/> with geometry translated to the local origin, or null if <paramref name="gLTFNodes"/> is null.</returns>
        public static GLTFScene? GLTFScene(this IEnumerable<GLTFNode>? gLTFNodes, string? name = null, IEnumerable<GLTFLight>? gLTFLights = null, GLTFCamera? gLTFCamera = null, Point3D? referencePointOverride = null)
        {
            if (gLTFNodes is null)
            {
                return null;
            }

            // Performance path for large scenes: direct accessors and adopting constructors are used
            // throughout to avoid the reflection-based deep clones of the serialization pattern.
            List<GLTFNode> gLTFNodes_Temp = [];
            BoundingBox3D? boundingBox3D = null;

            foreach (GLTFNode gLTFNode in gLTFNodes)
            {
                if (gLTFNode is null)
                {
                    continue;
                }

                gLTFNodes_Temp.Add(gLTFNode);

                BoundingBox3D? boundingBox3D_Temp = gLTFNode.Mesh3D_Direct?.GetBoundingBox();
                if (boundingBox3D_Temp is null)
                {
                    continue;
                }

                if (boundingBox3D is null)
                {
                    boundingBox3D = boundingBox3D_Temp;
                }
                else
                {
                    boundingBox3D.Add(boundingBox3D_Temp);
                }
            }

            Point3D? referencePoint = null;
            if (boundingBox3D is not null && boundingBox3D.GetCentroid() is Point3D centroid)
            {
                referencePoint = new Point3D(centroid.X, centroid.Y, boundingBox3D.Min.Z);
            }

            if (referencePointOverride is not null)
            {
                double z = referencePoint?.Z ?? 0;
                referencePoint = new Point3D(referencePointOverride.X, referencePointOverride.Y, z);
            }

            List<GLTFNode> gLTFNodes_Result = [];
            if (referencePoint is null)
            {
                gLTFNodes_Result.AddRange(gLTFNodes_Temp);
            }
            else
            {
                Vector3D vector3D = new(-referencePoint.X, -referencePoint.Y, -referencePoint.Z);
                foreach (GLTFNode gLTFNode in gLTFNodes_Temp)
                {
                    Mesh3D? mesh3D = gLTFNode.Mesh3D_Direct is null ? null : new Mesh3D(gLTFNode.Mesh3D_Direct);
                    if (mesh3D is not null)
                    {
                        mesh3D.Move(vector3D);
                    }

                    gLTFNodes_Result.Add(new GLTFNode(true, gLTFNode.Name, gLTFNode.Reference, mesh3D, gLTFNode.Color_Direct, gLTFNode.Opacity, gLTFNode.Properties));
                }
            }

            List<GLTFLight> gLTFLights_Temp = gLTFLights is null ? GLTFLights() : [.. gLTFLights];
            GLTFCamera gLTFCamera_Temp = gLTFCamera ?? new GLTFCamera("Default", null, null, 50, true);

            return new GLTFScene(true, name, referencePoint, gLTFNodes_Result, gLTFLights_Temp, gLTFCamera_Temp);
        }

        /// <summary>
        /// Creates a <see cref="Classes.GLTFScene"/> from the specified <see cref="ISerializableObject"/> instances.
        /// <para>Objects are converted through <see cref="Convert.ToGLTF_GLTFNodes(ISerializableObject?, double)"/>: registered <see cref="Interfaces.IGLTFNodeConverter"/> instances are consulted first, then <see cref="GLTFNode"/> pass-through and raw <see cref="IGeometry3D"/> triangulation. Unsupported objects are skipped.</para>
        /// </summary>
        /// <param name="serializableObjects">The <see cref="ISerializableObject"/> instances to be displayed. This value can be null.</param>
        /// <param name="name">The display name of the scene.</param>
        /// <param name="color">The default <see cref="Color"/> applied to converted geometry. This value can be null.</param>
        /// <param name="tolerance">The distance tolerance used during triangulation.</param>
        /// <returns>A <see cref="Classes.GLTFScene"/> with geometry translated to the local origin, or null if <paramref name="serializableObjects"/> is null.</returns>
        public static GLTFScene? GLTFScene(this IEnumerable<ISerializableObject>? serializableObjects, string? name = null, Color? color = null, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (serializableObjects is null)
            {
                return null;
            }

            List<GLTFNode> gLTFNodes = [];
            foreach (ISerializableObject serializableObject in serializableObjects)
            {
                List<GLTFNode>? gLTFNodes_Temp;
                if (color is not null && serializableObject is IGeometry3D geometry3D)
                {
                    // Explicit color override for raw geometry keeps the pre-registry behavior.
                    string? reference = Core.Create.UniqueReference(serializableObject)?.ToString();
                    GLTFNode? gLTFNode_Geometry = GLTFNode(geometry3D, serializableObject.GetType().Name, reference, color, 1, serializableObject.ToSystem_String(), tolerance);
                    gLTFNodes_Temp = gLTFNode_Geometry is null ? null : [gLTFNode_Geometry];
                }
                else
                {
                    gLTFNodes_Temp = Convert.ToGLTF_GLTFNodes(serializableObject, tolerance);
                }

                if (gLTFNodes_Temp is not null)
                {
                    gLTFNodes.AddRange(gLTFNodes_Temp);
                }
            }

            return GLTFScene(gLTFNodes, name);
        }

        /// <summary>
        /// Creates the default <see cref="GLTFLight"/> configuration: an ambient light and a directional sun light.
        /// <para>The directional light is named Sun so its direction can be recalculated dynamically, for example to simulate the sun position during the day.</para>
        /// </summary>
        /// <returns>A list of <see cref="GLTFLight"/> instances with the default lighting configuration.</returns>
        public static List<GLTFLight> GLTFLights()
        {
            Color color = new(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

            List<GLTFLight> result =
            [
                new GLTFLight("Ambient", LightType.Ambient, color, 0.6, null, null),
                new GLTFLight("Sun", LightType.Directional, color, 2.4, new Vector3D(-0.5, -0.7, -1), null)
            ];

            return result;
        }
    }
}
