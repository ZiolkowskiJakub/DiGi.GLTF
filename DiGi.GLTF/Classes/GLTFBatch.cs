namespace DiGi.GLTF.Classes
{
    /// <summary>
    /// Represents a single merged draw unit: the geometry of many <see cref="GLTFNode"/> instances sharing the same alpha mode, packed into contiguous vertex and index buffers.
    /// <para>Per-object styling is baked into the vertex colors and per-object identity is encoded in the object id vertex attribute, so the whole batch renders as one WebGL draw call while individual objects remain selectable.</para>
    /// </summary>
    public class GLTFBatch
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFBatch"/> class.
        /// </summary>
        /// <param name="blended">A value indicating whether the batch requires alpha blending (any contained object is semi-transparent).</param>
        /// <param name="positions">The packed vertex positions (3 floats per vertex).</param>
        /// <param name="colors">The packed vertex colors (4 bytes RGBA per vertex, normalized).</param>
        /// <param name="objectIds">The packed per-vertex object identifiers (1 float per vertex) indexing the batch entry list.</param>
        /// <param name="indexes">The packed triangle indices (3 ints per triangle).</param>
        /// <param name="min">The component-wise minimum of the positions (3 floats).</param>
        /// <param name="max">The component-wise maximum of the positions (3 floats).</param>
        public GLTFBatch(bool blended, float[] positions, byte[] colors, float[] objectIds, int[] indexes, float[] min, float[] max)
        {
            Blended = blended;
            Positions = positions;
            Colors = colors;
            ObjectIds = objectIds;
            Indexes = indexes;
            Min = min;
            Max = max;
        }

        /// <summary> Gets a value indicating whether the batch requires alpha blending. </summary>
        public bool Blended { get; }

        /// <summary> Gets the packed vertex colors (4 bytes RGBA per vertex, normalized). </summary>
        public byte[] Colors { get; }

        /// <summary> Gets the packed triangle indices (3 ints per triangle). </summary>
        public int[] Indexes { get; }

        /// <summary> Gets the component-wise maximum of the positions (3 floats). </summary>
        public float[] Max { get; }

        /// <summary> Gets the component-wise minimum of the positions (3 floats). </summary>
        public float[] Min { get; }

        /// <summary> Gets the packed per-vertex object identifiers (1 float per vertex) indexing the batch entry list. </summary>
        public float[] ObjectIds { get; }

        /// <summary> Gets the packed vertex positions (3 floats per vertex). </summary>
        public float[] Positions { get; }
    }
}
