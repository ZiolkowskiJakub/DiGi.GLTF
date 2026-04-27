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