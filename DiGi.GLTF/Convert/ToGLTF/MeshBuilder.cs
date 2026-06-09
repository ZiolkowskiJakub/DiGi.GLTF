using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Materials;
using System.Collections.Generic;

namespace DiGi.GLTF
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a visual object into a GLTF mesh builder, extracting its geometry and appearance properties to create a 3D representation.
        /// </summary>
        /// <param name="visualObject">The visual object to be converted. This parameter can be null.</param>
        /// <returns>A <see cref="MeshBuilder{VertexPosition, VertexColor1}"/> containing the generated GLTF mesh data and materials, or null if the <paramref name="visualObject"/> is null or lacks a valid visual representation.</returns>
        public static MeshBuilder<VertexPosition, VertexColor1>? ToGLTF(this IVisualObject? visualObject)
        {
            if (visualObject is null)
            {
                return null;
            }

            IVisual? visual = (visualObject as dynamic).Visual;
            if (visual is null)
            {
                return null;
            }

            string? reference = Core.Create.UniqueReference(visualObject)?.ToString();

            MeshBuilder<VertexPosition, VertexColor1> result = new(reference);

            if (visual is IVisualPolygonalFace3D visualPolygonalFace3D)
            {
                IFaceAppearance? faceAppearance = visualPolygonalFace3D.Appearance;
                if (faceAppearance is not null)
                {
                    IPolygonalFace3D? polygonalFace3D = visualPolygonalFace3D.Geometry;
                    if (polygonalFace3D is not null)
                    {
                        MaterialBuilder? materialBuilder_Surface = faceAppearance.ToGLTF();
                        result.Add(polygonalFace3D, materialBuilder_Surface);

                        ICurveAppearance? externalEdgeAppearance = faceAppearance.ExternalEdgeAppearance;
                        if (externalEdgeAppearance is not null)
                        {
                            IPolygonal3D? polygonal3D = polygonalFace3D.ExternalEdge;
                            if (polygonal3D is not null)
                            {
                                MaterialBuilder? materialBuilder_Curve = externalEdgeAppearance.ToGLTF();
                                MaterialBuilder? materialBuilder_Point = externalEdgeAppearance.PointAppearance?.ToGLTF();

                                if (materialBuilder_Curve is not null || materialBuilder_Point is not null)
                                {
                                    if (materialBuilder_Curve is not null)
                                    {
                                        result.Add(polygonal3D, materialBuilder_Curve);
                                    }

                                    if (materialBuilder_Point is not null)
                                    {
                                        List<Point3D>? point3Ds = polygonal3D.GetPoints();
                                        if (point3Ds is not null)
                                        {
                                            foreach (Point3D point3D in point3Ds)
                                            {
                                                result.Add(point3D, materialBuilder_Point);
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        ICurveAppearance? internalEdgeAppearance = faceAppearance.InternalEdgeAppearance;
                        if (internalEdgeAppearance is not null)
                        {
                            List<IPolygonal3D>? polygonal3Ds = polygonalFace3D.InternalEdges;
                            if (polygonal3Ds is not null)
                            {
                                MaterialBuilder? materialBuilder_Curve = internalEdgeAppearance.ToGLTF();
                                MaterialBuilder? materialBuilder_Point = internalEdgeAppearance.PointAppearance?.ToGLTF();

                                if (materialBuilder_Curve is not null || materialBuilder_Point is not null)
                                {
                                    foreach (IPolygonal3D polygonal3D in polygonal3Ds)
                                    {
                                        if (materialBuilder_Curve is not null)
                                        {
                                            result.Add(polygonal3D, materialBuilder_Curve);
                                        }

                                        if (materialBuilder_Point is not null)
                                        {
                                            List<Point3D>? point3Ds = polygonal3D.GetPoints();
                                            if (point3Ds is not null)
                                            {
                                                foreach (Point3D point3D in point3Ds)
                                                {
                                                    result.Add(point3D, materialBuilder_Point);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (visual is IVisualPolygonal3D visualPolygonal3D)
            {
                ICurveAppearance? curveAppearance = visualPolygonal3D.Appearance;
                if (curveAppearance is not null)
                {
                    IPolygonal3D? polygonal3D = visualPolygonal3D.Geometry;
                    if (polygonal3D != null)
                    {
                        MaterialBuilder? materialBuilder_Curve = curveAppearance.ToGLTF();
                        MaterialBuilder? materialBuilder_Point = curveAppearance.PointAppearance?.ToGLTF();

                        if (materialBuilder_Curve is not null)
                        {
                            result.Add(polygonal3D, materialBuilder_Curve);
                        }

                        if (materialBuilder_Point is not null)
                        {
                            List<Point3D>? point3Ds = polygonal3D.GetPoints();
                            if (point3Ds is not null)
                            {
                                foreach (Point3D point3D in point3Ds)
                                {
                                    result.Add(point3D, materialBuilder_Point);
                                }
                            }
                        }
                    }
                }
            }
            else if (visual is IVisualSegment3D visualSegment3D)
            {
                ICurveAppearance? curveAppearance = visualSegment3D.Appearance;
                if (curveAppearance is not null)
                {
                    Segment3D? segment3D = visualSegment3D.Geometry;
                    if (segment3D != null)
                    {
                        MaterialBuilder? materialBuilder_Curve = curveAppearance.ToGLTF();
                        MaterialBuilder? materialBuilder_Point = curveAppearance.PointAppearance?.ToGLTF();

                        if (materialBuilder_Curve is not null)
                        {
                            result.Add(segment3D, materialBuilder_Curve);
                        }

                        if (materialBuilder_Point is not null)
                        {
                            List<Point3D>? point3Ds = segment3D.GetPoints();
                            if (point3Ds is not null)
                            {
                                foreach (Point3D point3D in point3Ds)
                                {
                                    result.Add(point3D, materialBuilder_Point);
                                }
                            }
                        }
                    }
                }
            }
            else if (visual is IVisualMesh3D visualMesh3D)
            {
                IMeshAppearance? meshAppearance = visualMesh3D.Appearance;
                if (meshAppearance is not null)
                {
                    Mesh3D? mesh3D = visualMesh3D.Geometry;
                    if (mesh3D is not null)
                    {
                        MaterialBuilder? materialBuilder_Surface = meshAppearance.ToGLTF();
                        result.Add(mesh3D, materialBuilder_Surface);

                        ICurveAppearance? boundaryEdgeAppearance = meshAppearance.BoundaryEdgeAppearance;
                        ICurveAppearance? auxiliaryEdgeAppearance = meshAppearance.AuxiliaryEdgeAppearance;

                        if (boundaryEdgeAppearance is not null || auxiliaryEdgeAppearance is not null)
                        {
                            MaterialBuilder? materialBuilder_Polyloop = boundaryEdgeAppearance!.ToGLTF();
                            MaterialBuilder? materialBuilder_Segments = auxiliaryEdgeAppearance!.ToGLTF();

                            if (materialBuilder_Polyloop is not null || materialBuilder_Segments is not null)
                            {
                                List<Polyloop>? polyloops = null;
                                List<Segment3D>? auxiliarySegments = null;

                                if (materialBuilder_Polyloop is not null && materialBuilder_Segments is not null)
                                {
                                    polyloops = mesh3D.GetBoundaryEdges(out auxiliarySegments);
                                }
                                else if (materialBuilder_Polyloop is not null)
                                {
                                    polyloops = mesh3D.GetBoundaryEdges();
                                }
                                else
                                {
                                    auxiliarySegments = mesh3D.GetAuxiliarySegments();
                                }

                                if (polyloops is not null)
                                {
                                    foreach (Polyloop polyloop in polyloops)
                                    {
                                        result.Add(polyloop, materialBuilder_Polyloop);
                                    }
                                }

                                if (auxiliarySegments is not null)
                                {
                                    foreach (Segment3D auxiliarySegment in auxiliarySegments)
                                    {
                                        result.Add(auxiliarySegment, materialBuilder_Segments);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            ISerializableObject? serializableObject = (visualObject as dynamic).Object;
            if (serializableObject is not null)
            {
                result.Extras = serializableObject.ToSystem_String();
            }

            return result;
        }
    }
}