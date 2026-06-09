using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Materials;
using System.Collections.Generic;
using System.Numerics;

namespace DiGi.GLTF
{
    public static partial class Modify
    {
/// <summary>
/// Adds a three-dimensional line segment to the specified mesh builder using a specific material and vertex color.
/// </summary>
/// <param name="meshBuilder">The <see cref="MeshBuilder{VertexPosition, VertexColor1}"/> instance used to construct the mesh. This value can be null.</param>
/// <param name="segment3D">The <see cref="Segment3D"/> representing the line segment defined by two points in 3D space to be added. This value can be null.</param>
/// <param name="materialBuilder">The <see cref="MaterialBuilder"/> defining the material used for rendering the geometric primitive. This value can be null.</param>
/// <param name="vertexColor1_Override">An optional <see cref="VertexColor1"/> to override the default vertex color. If this value is null, a default white color (Vector4.One) is utilized.</param>
/// <returns>A <see cref="PrimitiveBuilder{MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty}"/> if the segment was successfully added; otherwise, null if any required parameter is null or if the segment points cannot be converted to <see cref="VertexPosition"/>.</returns>
        public static PrimitiveBuilder<MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty>? Add(this MeshBuilder<VertexPosition, VertexColor1>? meshBuilder, Segment3D? segment3D, MaterialBuilder? materialBuilder, VertexColor1? vertexColor1_Override = null)
        {
            if (meshBuilder is null || segment3D is null || materialBuilder is null)
            {
                return null;
            }

            if (segment3D.Start.ToGLTF() is not VertexPosition vertexPosition_1)
            {
                return null;
            }

            if (segment3D.End.ToGLTF() is not VertexPosition vertexPosition_2)
            {
                return null;
            }

            VertexColor1 vertexColor1 = vertexColor1_Override ?? new VertexColor1(Vector4.One);

            PrimitiveBuilder<MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty> result = meshBuilder.UsePrimitive(materialBuilder, 2);
            result.AddLine((vertexPosition_1, vertexColor1), (vertexPosition_2, vertexColor1));

            return result;
        }

/// <summary>
/// Adds line segments from an <see cref="ISegmentable3D"/> source to a <see cref="MeshBuilder{VertexPosition, VertexColor1}"/> as a geometric primitive.
/// </summary>
/// <param name="meshBuilder">The mesh builder instance used to create the primitive. This parameter can be null.</param>
/// <param name="segmentable3D">The 3D geometry source that provides the line segments to be added. This parameter can be null.</param>
/// <param name="materialBuilder">The material definition to be applied to the created primitive. This parameter can be null.</param>
/// <param name="vertexColor1_Override">An optional override for the vertex color of the lines. If this value is null, a default white color (Vector4.One) is used.</param>
/// <returns>
/// A <see cref="PrimitiveBuilder{MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty}"/> containing the generated line segments if successful; 
/// otherwise, null if <paramref name="meshBuilder"/>, <paramref name="segmentable3D"/>, or <paramref name="materialBuilder"/> is null, 
/// or if the segment data cannot be retrieved as a <see cref="List{Segment3D}"/>.
/// </returns>
        public static PrimitiveBuilder<MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty>? Add(this MeshBuilder<VertexPosition, VertexColor1>? meshBuilder, ISegmentable3D? segmentable3D, MaterialBuilder? materialBuilder, VertexColor1? vertexColor1_Override = null)
        {
            if (meshBuilder is null || segmentable3D is null || materialBuilder is null)
            {
                return null;
            }

            if (segmentable3D.GetSegments() is not List<Segment3D> segment3Ds)
            {
                return null;
            }

            PrimitiveBuilder<MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty> result = meshBuilder.UsePrimitive(materialBuilder, 2);

            VertexColor1 vertexColor1 = vertexColor1_Override ?? new VertexColor1(Vector4.One);

            foreach (Segment3D segment3D in segment3Ds)
            {
                if (segment3D.Start.ToGLTF() is not VertexPosition vertexPosition_1)
                {
                    return null;
                }

                if (segment3D.Start.ToGLTF() is not VertexPosition vertexPosition_2)
                {
                    return null;
                }

                result.AddLine((vertexPosition_1, vertexColor1), (vertexPosition_2, vertexColor1));
            }

            return result;
        }

/// <summary>
/// Adds a single point to the mesh builder as a geometric primitive using the specified material and an optional vertex color override.
/// </summary>
/// <param name="meshBuilder">The <see cref="MeshBuilder{VertexPosition, VertexColor1}"/> instance used to construct the mesh. This value can be null.</param>
/// <param name="point3D">The <see cref="Point3D"/> representing the position of the point in three-dimensional space. This value can be null.</param>
/// <param name="materialBuilder">The <see cref="MaterialBuilder"/> defining the material for the created primitive. This value can be null.</param>
/// <param name="vertexColor1_Override">An optional <see cref="VertexColor1"/> to override the default vertex color. If this value is null, a default white color is used.</param>
/// <returns>
/// A <see cref="PrimitiveBuilder{MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty}"/> if the point was successfully added; 
/// otherwise, null if <paramref name="meshBuilder"/>, <paramref name="point3D"/>, or <paramref name="materialBuilder"/> is null, 
/// or if the conversion of <paramref name="point3D"/> to a GLTF vertex position fails.
/// </returns>
        public static PrimitiveBuilder<MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty>? Add(this MeshBuilder<VertexPosition, VertexColor1>? meshBuilder, Point3D? point3D, MaterialBuilder? materialBuilder, VertexColor1? vertexColor1_Override = null)
        {
            if (meshBuilder is null || point3D is null || materialBuilder is null)
            {
                return null;
            }

            if (point3D.ToGLTF() is not VertexPosition vertexPosition)
            {
                return null;
            }

            PrimitiveBuilder<MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty> result = meshBuilder.UsePrimitive(materialBuilder, 1);

            result.AddPoint((vertexPosition, vertexColor1_Override ?? new VertexColor1(Vector4.One)));

            return result;
        }

/// <summary>
/// Adds the geometry from a <see cref="Mesh3D"/> instance to a <see cref="MeshBuilder{VertexPosition, VertexColor1}"/> as a geometric primitive.
/// </summary>
/// <param name="meshBuilder">The mesh builder used to create the primitive. This parameter can be null.</param>
/// <param name="mesh3D">The source three-dimensional mesh containing vertices and indices. This parameter can be null.</param>
/// <param name="materialBuilder">The material definition to be applied to the resulting geometric primitive. This parameter can be null.</param>
/// <param name="vertexColor1_Override">An optional override for the vertex color. If this parameter is null, a default white color (Vector4.One) is used.</param>
/// <returns>
/// A <see cref="PrimitiveBuilder{MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty}"/> if the mesh was successfully added; 
/// otherwise, null if any of the required parameters are null or if the geometry data is invalid.
/// </returns>
        public static PrimitiveBuilder<MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty>? Add(this MeshBuilder<VertexPosition, VertexColor1>? meshBuilder, Mesh3D? mesh3D, MaterialBuilder? materialBuilder, VertexColor1? vertexColor1_Override = null)
        {
            if (meshBuilder is null || mesh3D is null || materialBuilder is null)
            {
                return null;
            }

            if (mesh3D.GetPoints() is not List<Point3D> point3Ds)
            {
                return null;
            }

            if (mesh3D.GetIndexes() is not List<int[]> indexes || indexes.Count < 3)
            {
                return null;
            }

            VertexColor1 vertexColor1 = vertexColor1_Override ?? new VertexColor1(Vector4.One);

            PrimitiveBuilder<MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty> result = meshBuilder.UsePrimitive(materialBuilder);
            foreach (int[] indexes_Triangle in indexes)
            {
                if (point3Ds[indexes_Triangle[0]].ToGLTF() is not VertexPosition vertexPosition_1)
                {
                    return null;
                }

                if (point3Ds[indexes_Triangle[1]].ToGLTF() is not VertexPosition vertexPosition_2)
                {
                    return null;
                }

                if (point3Ds[indexes_Triangle[2]].ToGLTF() is not VertexPosition vertexPosition_3)
                {
                    return null;
                }

                result.AddTriangle(
                    (vertexPosition_1, vertexColor1),
                    (vertexPosition_2, vertexColor1),
                    (vertexPosition_3, vertexColor1)
                );
            }

            return result;
        }

/// <summary>
/// Adds a three-dimensional triangle to the specified mesh builder using a provided material and an optional vertex color override.
/// </summary>
/// <param name="meshBuilder">The <see cref="MeshBuilder{VertexPosition, VertexColor1}"/> instance used to construct the mesh. This value can be null.</param>
/// <param name="triangle3D">The <see cref="Triangle3D"/> geometry representing the triangle to be added to the mesh. This value can be null.</param>
/// <param name="materialBuilder">The <see cref="MaterialBuilder"/> defining the material for the geometric primitive. This value can be null.</param>
/// <param name="vertexColor1_Override">An optional <see cref="VertexColor1"/> override to apply to all vertices of the triangle. If this value is null, a default color based on <see cref="Vector4.One"/> is used.</param>
/// <returns>
/// A <see cref="PrimitiveBuilder{MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty}"/> if the triangle was successfully added; 
/// otherwise, null if <paramref name="meshBuilder"/>, <paramref name="triangle3D"/>, or <paramref name="materialBuilder"/> is null, 
/// or if any vertex of the <paramref name="triangle3D"/> cannot be converted to a <see cref="VertexPosition"/>.
/// </returns>
        public static PrimitiveBuilder<MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty>? Add(this MeshBuilder<VertexPosition, VertexColor1>? meshBuilder, Triangle3D? triangle3D, MaterialBuilder? materialBuilder, VertexColor1? vertexColor1_Override = null)
        {
            if (meshBuilder is null || triangle3D is null || materialBuilder is null)
            {
                return null;
            }

            PrimitiveBuilder<MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty> result = meshBuilder.UsePrimitive(materialBuilder);

            if (triangle3D[0].ToGLTF() is not VertexPosition vertexPosition_1)
            {
                return null;
            }

            if (triangle3D[1].ToGLTF() is not VertexPosition vertexPosition_2)
            {
                return null;
            }

            if (triangle3D[2].ToGLTF() is not VertexPosition vertexPosition_3)
            {
                return null;
            }

            VertexColor1 vertexColor1 = vertexColor1_Override ?? new VertexColor1(Vector4.One);

            result.AddTriangle(
                (vertexPosition_1, vertexColor1),
                (vertexPosition_2, vertexColor1),
                (vertexPosition_3, vertexColor1)
            );

            return result;
        }

/// <summary>
/// Adds a 3D polygonal face to the specified mesh builder as a geometric primitive.
/// </summary>
/// <param name="meshBuilder">The <see cref="MeshBuilder{VertexPosition, VertexColor1}"/> instance to which the face is added. This value can be null.</param>
/// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> representing the 3D polygonal face to add. This value can be null.</param>
/// <param name="materialBuilder">The <see cref="MaterialBuilder"/> defining the material for the resulting primitive. This value can be null.</param>
/// <param name="vertexColor1_Override">An optional <see cref="VertexColor1"/> override to apply to the vertices of the face. Defaults to null.</param>
/// <param name="tolerance">The distance tolerance used when creating the mesh from the polygonal face. Defaults to <see cref="Core.Constants.Tolerance.Distance"/>.</param>
/// <returns>A <see cref="PrimitiveBuilder{MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty}"/> for the added primitive if successful; otherwise, null if <paramref name="meshBuilder"/>, <paramref name="polygonalFace3D"/>, or <paramref name="materialBuilder"/> is null, or if the mesh creation fails.</returns>
        public static PrimitiveBuilder<MaterialBuilder, VertexPosition, VertexColor1, VertexEmpty>? Add(this MeshBuilder<VertexPosition, VertexColor1>? meshBuilder, IPolygonalFace3D? polygonalFace3D, MaterialBuilder? materialBuilder, VertexColor1? vertexColor1_Override = null, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (meshBuilder is null || polygonalFace3D is null || materialBuilder is null)
            {
                return null;
            }

            Mesh3D? mesh3D = Geometry.Spatial.Create.Mesh3D(polygonalFace3D, tolerance);
            if (mesh3D is null)
            {
                return null;
            }

            return Add(meshBuilder, mesh3D, materialBuilder, vertexColor1_Override);
        }
    }
}