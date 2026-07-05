namespace DiGi.GLTF.Classes
{
    /// <summary>
    /// Represents the identity of a single object inside a <see cref="GLTFBatch"/>: its reference, its serialized properties and its contiguous vertex and index ranges within the merged buffers.
    /// <para>The index of the entry in the entry list is the object id encoded in the batch vertex attribute, allowing viewers to map a picked vertex back to the original object.</para>
    /// </summary>
    public class GLTFBatchEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GLTFBatchEntry"/> class.
        /// </summary>
        /// <param name="reference">The unique reference identifying the source object.</param>
        /// <param name="name">The display name of the source object.</param>
        /// <param name="properties">The JSON string with the properties of the source object. This value can be null.</param>
        /// <param name="batchIndex">The index of the <see cref="GLTFBatch"/> containing the object geometry.</param>
        /// <param name="vertexStart">The first vertex of the object within the merged vertex buffers.</param>
        /// <param name="vertexCount">The number of vertices of the object.</param>
        /// <param name="indexStart">The first index of the object within the merged index buffer.</param>
        /// <param name="indexCount">The number of indices of the object.</param>
        public GLTFBatchEntry(string? reference, string? name, string? properties, int batchIndex, int vertexStart, int vertexCount, int indexStart, int indexCount)
        {
            Reference = reference;
            Name = name;
            Properties = properties;
            BatchIndex = batchIndex;
            VertexStart = vertexStart;
            VertexCount = vertexCount;
            IndexStart = indexStart;
            IndexCount = indexCount;
        }

        /// <summary> Gets the index of the <see cref="GLTFBatch"/> containing the object geometry. </summary>
        public int BatchIndex { get; }

        /// <summary> Gets the number of indices of the object. </summary>
        public int IndexCount { get; }

        /// <summary> Gets the first index of the object within the merged index buffer. </summary>
        public int IndexStart { get; }

        /// <summary> Gets the display name of the source object. </summary>
        public string? Name { get; }

        /// <summary> Gets the JSON string with the properties of the source object. </summary>
        public string? Properties { get; }

        /// <summary> Gets the unique reference identifying the source object. </summary>
        public string? Reference { get; }

        /// <summary> Gets the number of vertices of the object. </summary>
        public int VertexCount { get; }

        /// <summary> Gets the first vertex of the object within the merged vertex buffers. </summary>
        public int VertexStart { get; }
    }
}
