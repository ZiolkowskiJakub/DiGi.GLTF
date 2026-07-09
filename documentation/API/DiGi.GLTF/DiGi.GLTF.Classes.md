#### [DiGi\.GLTF](DiGi.GLTF.Overview.md 'DiGi\.GLTF\.Overview')

## DiGi\.GLTF\.Classes Namespace
### Classes

<a name='DiGi.GLTF.Classes.GLTFBatch'></a>

## GLTFBatch Class

Represents a single merged draw unit: the geometry of many [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') instances sharing the same alpha mode, packed into contiguous vertex and index buffers\.

Per-object styling is baked into the vertex colors and per-object identity is encoded in the object id vertex attribute, so the whole batch renders as one WebGL draw call while individual objects remain selectable.

```csharp
public class GLTFBatch
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GLTFBatch
### Constructors

<a name='DiGi.GLTF.Classes.GLTFBatch.GLTFBatch(bool,float[],byte[],float[],int[],float[],float[])'></a>

## GLTFBatch\(bool, float\[\], byte\[\], float\[\], int\[\], float\[\], float\[\]\) Constructor

Initializes a new instance of the [GLTFBatch](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFBatch 'DiGi\.GLTF\.Classes\.GLTFBatch') class\.

```csharp
public GLTFBatch(bool blended, float[] positions, byte[] colors, float[] objectIds, int[] indexes, float[] min, float[] max);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFBatch.GLTFBatch(bool,float[],byte[],float[],int[],float[],float[]).blended'></a>

`blended` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the batch requires alpha blending \(any contained object is semi\-transparent\)\.

<a name='DiGi.GLTF.Classes.GLTFBatch.GLTFBatch(bool,float[],byte[],float[],int[],float[],float[]).positions'></a>

`positions` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The packed vertex positions \(3 floats per vertex\)\.

<a name='DiGi.GLTF.Classes.GLTFBatch.GLTFBatch(bool,float[],byte[],float[],int[],float[],float[]).colors'></a>

`colors` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The packed vertex colors \(4 bytes RGBA per vertex, normalized\)\.

<a name='DiGi.GLTF.Classes.GLTFBatch.GLTFBatch(bool,float[],byte[],float[],int[],float[],float[]).objectIds'></a>

`objectIds` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The packed per\-vertex object identifiers \(1 float per vertex\) indexing the batch entry list\.

<a name='DiGi.GLTF.Classes.GLTFBatch.GLTFBatch(bool,float[],byte[],float[],int[],float[],float[]).indexes'></a>

`indexes` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The packed triangle indices \(3 ints per triangle\)\.

<a name='DiGi.GLTF.Classes.GLTFBatch.GLTFBatch(bool,float[],byte[],float[],int[],float[],float[]).min'></a>

`min` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The component\-wise minimum of the positions \(3 floats\)\.

<a name='DiGi.GLTF.Classes.GLTFBatch.GLTFBatch(bool,float[],byte[],float[],int[],float[],float[]).max'></a>

`max` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The component\-wise maximum of the positions \(3 floats\)\.
### Properties

<a name='DiGi.GLTF.Classes.GLTFBatch.Blended'></a>

## GLTFBatch\.Blended Property

Gets a value indicating whether the batch requires alpha blending\.

```csharp
public bool Blended { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GLTF.Classes.GLTFBatch.Colors'></a>

## GLTFBatch\.Colors Property

Gets the packed vertex colors \(4 bytes RGBA per vertex, normalized\)\.

```csharp
public byte[] Colors { get; }
```

#### Property Value
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.GLTF.Classes.GLTFBatch.Indexes'></a>

## GLTFBatch\.Indexes Property

Gets the packed triangle indices \(3 ints per triangle\)\.

```csharp
public int[] Indexes { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.GLTF.Classes.GLTFBatch.Max'></a>

## GLTFBatch\.Max Property

Gets the component\-wise maximum of the positions \(3 floats\)\.

```csharp
public float[] Max { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.GLTF.Classes.GLTFBatch.Min'></a>

## GLTFBatch\.Min Property

Gets the component\-wise minimum of the positions \(3 floats\)\.

```csharp
public float[] Min { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.GLTF.Classes.GLTFBatch.ObjectIds'></a>

## GLTFBatch\.ObjectIds Property

Gets the packed per\-vertex object identifiers \(1 float per vertex\) indexing the batch entry list\.

```csharp
public float[] ObjectIds { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.GLTF.Classes.GLTFBatch.Positions'></a>

## GLTFBatch\.Positions Property

Gets the packed vertex positions \(3 floats per vertex\)\.

```csharp
public float[] Positions { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.GLTF.Classes.GLTFBatchEntry'></a>

## GLTFBatchEntry Class

Represents the identity of a single object inside a [GLTFBatch](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFBatch 'DiGi\.GLTF\.Classes\.GLTFBatch'): its reference, its serialized properties and its contiguous vertex and index ranges within the merged buffers\.

The index of the entry in the entry list is the object id encoded in the batch vertex attribute, allowing viewers to map a picked vertex back to the original object.

```csharp
public class GLTFBatchEntry
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GLTFBatchEntry
### Constructors

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.GLTFBatchEntry(string,string,string,int,int,int,int,int)'></a>

## GLTFBatchEntry\(string, string, string, int, int, int, int, int\) Constructor

Initializes a new instance of the [GLTFBatchEntry](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFBatchEntry 'DiGi\.GLTF\.Classes\.GLTFBatchEntry') class\.

```csharp
public GLTFBatchEntry(string? reference, string? name, string? properties, int batchIndex, int vertexStart, int vertexCount, int indexStart, int indexCount);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.GLTFBatchEntry(string,string,string,int,int,int,int,int).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique reference identifying the source object\.

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.GLTFBatchEntry(string,string,string,int,int,int,int,int).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the source object\.

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.GLTFBatchEntry(string,string,string,int,int,int,int,int).properties'></a>

`properties` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The JSON string with the properties of the source object\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.GLTFBatchEntry(string,string,string,int,int,int,int,int).batchIndex'></a>

`batchIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the [GLTFBatch](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFBatch 'DiGi\.GLTF\.Classes\.GLTFBatch') containing the object geometry\.

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.GLTFBatchEntry(string,string,string,int,int,int,int,int).vertexStart'></a>

`vertexStart` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The first vertex of the object within the merged vertex buffers\.

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.GLTFBatchEntry(string,string,string,int,int,int,int,int).vertexCount'></a>

`vertexCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of vertices of the object\.

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.GLTFBatchEntry(string,string,string,int,int,int,int,int).indexStart'></a>

`indexStart` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The first index of the object within the merged index buffer\.

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.GLTFBatchEntry(string,string,string,int,int,int,int,int).indexCount'></a>

`indexCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of indices of the object\.
### Properties

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.BatchIndex'></a>

## GLTFBatchEntry\.BatchIndex Property

Gets the index of the [GLTFBatch](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFBatch 'DiGi\.GLTF\.Classes\.GLTFBatch') containing the object geometry\.

```csharp
public int BatchIndex { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.IndexCount'></a>

## GLTFBatchEntry\.IndexCount Property

Gets the number of indices of the object\.

```csharp
public int IndexCount { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.IndexStart'></a>

## GLTFBatchEntry\.IndexStart Property

Gets the first index of the object within the merged index buffer\.

```csharp
public int IndexStart { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.Name'></a>

## GLTFBatchEntry\.Name Property

Gets the display name of the source object\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.Properties'></a>

## GLTFBatchEntry\.Properties Property

Gets the JSON string with the properties of the source object\.

```csharp
public string? Properties { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.Reference'></a>

## GLTFBatchEntry\.Reference Property

Gets the unique reference identifying the source object\.

```csharp
public string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.VertexCount'></a>

## GLTFBatchEntry\.VertexCount Property

Gets the number of vertices of the object\.

```csharp
public int VertexCount { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.GLTF.Classes.GLTFBatchEntry.VertexStart'></a>

## GLTFBatchEntry\.VertexStart Property

Gets the first vertex of the object within the merged vertex buffers\.

```csharp
public int VertexStart { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.GLTF.Classes.GLTFCamera'></a>

## GLTFCamera Class

Represents a camera within a [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene'), defined by its position, target, field of view and automatic framing behavior\.

```csharp
public class GLTFCamera : DiGi.Core.Classes.SerializableObject, DiGi.GLTF.Interfaces.IGLTFSerializableObject, DiGi.GLTF.Interfaces.IGLTFObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → GLTFCamera

Implements [IGLTFSerializableObject](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFSerializableObject 'DiGi\.GLTF\.Interfaces\.IGLTFSerializableObject'), [IGLTFObject](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFObject 'DiGi\.GLTF\.Interfaces\.IGLTFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.GLTF.Classes.GLTFCamera.GLTFCamera(DiGi.GLTF.Classes.GLTFCamera)'></a>

## GLTFCamera\(GLTFCamera\) Constructor

Initializes a new instance of the [GLTFCamera](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera 'DiGi\.GLTF\.Classes\.GLTFCamera') class by copying an existing [GLTFCamera](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera 'DiGi\.GLTF\.Classes\.GLTFCamera') instance\.

```csharp
public GLTFCamera(DiGi.GLTF.Classes.GLTFCamera? gLTFCamera);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFCamera.GLTFCamera(DiGi.GLTF.Classes.GLTFCamera).gLTFCamera'></a>

`gLTFCamera` [GLTFCamera](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera 'DiGi\.GLTF\.Classes\.GLTFCamera')

The [GLTFCamera](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera 'DiGi\.GLTF\.Classes\.GLTFCamera') instance to copy from\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFCamera.GLTFCamera(string,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,bool)'></a>

## GLTFCamera\(string, Point3D, Point3D, double, bool\) Constructor

Initializes a new instance of the [GLTFCamera](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera 'DiGi\.GLTF\.Classes\.GLTFCamera') class\.

```csharp
public GLTFCamera(string? name, DiGi.Geometry.Spatial.Classes.Point3D? position, DiGi.Geometry.Spatial.Classes.Point3D? target, double fieldOfView, bool autoFrame);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFCamera.GLTFCamera(string,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,bool).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the camera\.

<a name='DiGi.GLTF.Classes.GLTFCamera.GLTFCamera(string,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,bool).position'></a>

`position` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') position of the camera\. This value can be null when [autoFrame](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera.GLTFCamera(string,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,bool).autoFrame 'DiGi\.GLTF\.Classes\.GLTFCamera\.GLTFCamera\(string, DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, bool\)\.autoFrame') is true\.

<a name='DiGi.GLTF.Classes.GLTFCamera.GLTFCamera(string,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,bool).target'></a>

`target` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') the camera looks at\. This value can be null when [autoFrame](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera.GLTFCamera(string,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,bool).autoFrame 'DiGi\.GLTF\.Classes\.GLTFCamera\.GLTFCamera\(string, DiGi\.Geometry\.Spatial\.Classes\.Point3D, DiGi\.Geometry\.Spatial\.Classes\.Point3D, double, bool\)\.autoFrame') is true\.

<a name='DiGi.GLTF.Classes.GLTFCamera.GLTFCamera(string,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,bool).fieldOfView'></a>

`fieldOfView` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The vertical field of view in degrees\.

<a name='DiGi.GLTF.Classes.GLTFCamera.GLTFCamera(string,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,bool).autoFrame'></a>

`autoFrame` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the camera automatically frames the whole scene bounding box on load\.

<a name='DiGi.GLTF.Classes.GLTFCamera.GLTFCamera(System.Text.Json.Nodes.JsonObject)'></a>

## GLTFCamera\(JsonObject\) Constructor

Initializes a new instance of the [GLTFCamera](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera 'DiGi\.GLTF\.Classes\.GLTFCamera') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public GLTFCamera(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFCamera.GLTFCamera(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the camera\. This value can be null\.
### Properties

<a name='DiGi.GLTF.Classes.GLTFCamera.AutoFrame'></a>

## GLTFCamera\.AutoFrame Property

Gets a value indicating whether the camera automatically frames the whole scene bounding box on load\.

```csharp
public bool AutoFrame { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GLTF.Classes.GLTFCamera.FieldOfView'></a>

## GLTFCamera\.FieldOfView Property

Gets the vertical field of view in degrees\.

```csharp
public double FieldOfView { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GLTF.Classes.GLTFCamera.Name'></a>

## GLTFCamera\.Name Property

Gets the display name of the camera\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GLTF.Classes.GLTFCamera.Position'></a>

## GLTFCamera\.Position Property

Gets the [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') position of the camera\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Position { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.GLTF.Classes.GLTFCamera.Target'></a>

## GLTFCamera\.Target Property

Gets the [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') the camera looks at\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Target { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.GLTF.Classes.GLTFLight'></a>

## GLTFLight Class

Represents a light source within a [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene'), defined by its type, color, intensity, direction and position\.

```csharp
public class GLTFLight : DiGi.Core.Classes.SerializableObject, DiGi.GLTF.Interfaces.IGLTFSerializableObject, DiGi.GLTF.Interfaces.IGLTFObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → GLTFLight

Implements [IGLTFSerializableObject](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFSerializableObject 'DiGi\.GLTF\.Interfaces\.IGLTFSerializableObject'), [IGLTFObject](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFObject 'DiGi\.GLTF\.Interfaces\.IGLTFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.GLTF.Classes.GLTFLight.GLTFLight(DiGi.GLTF.Classes.GLTFLight)'></a>

## GLTFLight\(GLTFLight\) Constructor

Initializes a new instance of the [GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight') class by copying an existing [GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight') instance\.

```csharp
public GLTFLight(DiGi.GLTF.Classes.GLTFLight? gLTFLight);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFLight.GLTFLight(DiGi.GLTF.Classes.GLTFLight).gLTFLight'></a>

`gLTFLight` [GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight')

The [GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight') instance to copy from\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFLight.GLTFLight(string,DiGi.GLTF.Enums.LightType,DiGi.Core.Classes.Color,double,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## GLTFLight\(string, LightType, Color, double, Vector3D, Point3D\) Constructor

Initializes a new instance of the [GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight') class\.

```csharp
public GLTFLight(string? name, DiGi.GLTF.Enums.LightType lightType, DiGi.Core.Classes.Color? color, double intensity, DiGi.Geometry.Spatial.Classes.Vector3D? direction, DiGi.Geometry.Spatial.Classes.Point3D? position);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFLight.GLTFLight(string,DiGi.GLTF.Enums.LightType,DiGi.Core.Classes.Color,double,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Point3D).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the light\.

<a name='DiGi.GLTF.Classes.GLTFLight.GLTFLight(string,DiGi.GLTF.Enums.LightType,DiGi.Core.Classes.Color,double,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Point3D).lightType'></a>

`lightType` [LightType](DiGi.GLTF.Enums.md#DiGi.GLTF.Enums.LightType 'DiGi\.GLTF\.Enums\.LightType')

The [LightType](DiGi.GLTF.Enums.md#DiGi.GLTF.Enums.LightType 'DiGi\.GLTF\.Enums\.LightType') of the light\.

<a name='DiGi.GLTF.Classes.GLTFLight.GLTFLight(string,DiGi.GLTF.Enums.LightType,DiGi.Core.Classes.Color,double,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Point3D).color'></a>

`color` [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

The [Color](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight.Color 'DiGi\.GLTF\.Classes\.GLTFLight\.Color') of the emitted light\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFLight.GLTFLight(string,DiGi.GLTF.Enums.LightType,DiGi.Core.Classes.Color,double,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Point3D).intensity'></a>

`intensity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The intensity of the light where 1 is the default full intensity\.

<a name='DiGi.GLTF.Classes.GLTFLight.GLTFLight(string,DiGi.GLTF.Enums.LightType,DiGi.Core.Classes.Color,double,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Point3D).direction'></a>

`direction` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') direction of the light rays for directional lights\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFLight.GLTFLight(string,DiGi.GLTF.Enums.LightType,DiGi.Core.Classes.Color,double,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Geometry.Spatial.Classes.Point3D).position'></a>

`position` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') position of the light for point lights\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFLight.GLTFLight(System.Text.Json.Nodes.JsonObject)'></a>

## GLTFLight\(JsonObject\) Constructor

Initializes a new instance of the [GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public GLTFLight(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFLight.GLTFLight(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the light\. This value can be null\.
### Properties

<a name='DiGi.GLTF.Classes.GLTFLight.Color'></a>

## GLTFLight\.Color Property

Gets the [Color](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight.Color 'DiGi\.GLTF\.Classes\.GLTFLight\.Color') of the emitted light\.

```csharp
public DiGi.Core.Classes.Color? Color { get; }
```

#### Property Value
[DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

<a name='DiGi.GLTF.Classes.GLTFLight.Direction'></a>

## GLTFLight\.Direction Property

Gets the [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') direction of the light rays for directional lights\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Direction { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

<a name='DiGi.GLTF.Classes.GLTFLight.Intensity'></a>

## GLTFLight\.Intensity Property

Gets the intensity of the light where 1 is the default full intensity\.

```csharp
public double Intensity { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GLTF.Classes.GLTFLight.LightType'></a>

## GLTFLight\.LightType Property

Gets the [LightType](DiGi.GLTF.Enums.md#DiGi.GLTF.Enums.LightType 'DiGi\.GLTF\.Enums\.LightType') of the light\.

```csharp
public DiGi.GLTF.Enums.LightType LightType { get; }
```

#### Property Value
[LightType](DiGi.GLTF.Enums.md#DiGi.GLTF.Enums.LightType 'DiGi\.GLTF\.Enums\.LightType')

<a name='DiGi.GLTF.Classes.GLTFLight.Name'></a>

## GLTFLight\.Name Property

Gets the display name of the light\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GLTF.Classes.GLTFLight.Position'></a>

## GLTFLight\.Position Property

Gets the [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') position of the light for point lights\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Position { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.GLTF.Classes.GLTFModel'></a>

## GLTFModel Class

Represents a model holding multiple [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') instances together with general model properties\.

```csharp
public class GLTFModel : DiGi.Core.Classes.SerializableObject, DiGi.GLTF.Interfaces.IGLTFSerializableObject, DiGi.GLTF.Interfaces.IGLTFObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → GLTFModel

Implements [IGLTFSerializableObject](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFSerializableObject 'DiGi\.GLTF\.Interfaces\.IGLTFSerializableObject'), [IGLTFObject](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFObject 'DiGi\.GLTF\.Interfaces\.IGLTFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.GLTF.Classes.GLTFModel.GLTFModel(DiGi.GLTF.Classes.GLTFModel)'></a>

## GLTFModel\(GLTFModel\) Constructor

Initializes a new instance of the [GLTFModel](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFModel 'DiGi\.GLTF\.Classes\.GLTFModel') class by copying an existing [GLTFModel](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFModel 'DiGi\.GLTF\.Classes\.GLTFModel') instance\.

```csharp
public GLTFModel(DiGi.GLTF.Classes.GLTFModel? gLTFModel);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFModel.GLTFModel(DiGi.GLTF.Classes.GLTFModel).gLTFModel'></a>

`gLTFModel` [GLTFModel](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFModel 'DiGi\.GLTF\.Classes\.GLTFModel')

The [GLTFModel](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFModel 'DiGi\.GLTF\.Classes\.GLTFModel') instance to copy from\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFModel.GLTFModel(string,string,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFScene_)'></a>

## GLTFModel\(string, string, IEnumerable\<GLTFScene\>\) Constructor

Initializes a new instance of the [GLTFModel](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFModel 'DiGi\.GLTF\.Classes\.GLTFModel') class\.

```csharp
public GLTFModel(string? name, string? description, System.Collections.Generic.IEnumerable<DiGi.GLTF.Classes.GLTFScene>? scenes);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFModel.GLTFModel(string,string,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFScene_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the model\.

<a name='DiGi.GLTF.Classes.GLTFModel.GLTFModel(string,string,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFScene_).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the model\.

<a name='DiGi.GLTF.Classes.GLTFModel.GLTFModel(string,string,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFScene_).scenes'></a>

`scenes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') instances contained in the model\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFModel.GLTFModel(System.Text.Json.Nodes.JsonObject)'></a>

## GLTFModel\(JsonObject\) Constructor

Initializes a new instance of the [GLTFModel](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFModel 'DiGi\.GLTF\.Classes\.GLTFModel') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public GLTFModel(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFModel.GLTFModel(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the model\. This value can be null\.
### Properties

<a name='DiGi.GLTF.Classes.GLTFModel.Description'></a>

## GLTFModel\.Description Property

Gets the description of the model\.

```csharp
public string? Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GLTF.Classes.GLTFModel.Name'></a>

## GLTFModel\.Name Property

Gets the display name of the model\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GLTF.Classes.GLTFModel.Scenes'></a>

## GLTFModel\.Scenes Property

Gets the [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') instances contained in the model\.

```csharp
public System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFScene>? Scenes { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.GLTF.Classes.GLTFNode'></a>

## GLTFNode Class

Represents a single displayable and selectable object within a [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene'), holding triangulated geometry, styling and the serialized properties of the source object\.

```csharp
public class GLTFNode : DiGi.Core.Classes.SerializableObject, DiGi.GLTF.Interfaces.IGLTFSerializableObject, DiGi.GLTF.Interfaces.IGLTFObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → GLTFNode

Implements [IGLTFSerializableObject](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFSerializableObject 'DiGi\.GLTF\.Interfaces\.IGLTFSerializableObject'), [IGLTFObject](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFObject 'DiGi\.GLTF\.Interfaces\.IGLTFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(bool,string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string)'></a>

## GLTFNode\(bool, string, string, Mesh3D, Color, double, string\) Constructor

Initializes a new instance of the [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') class adopting the given instances without cloning\.

Performance path for large scene generation: the caller transfers ownership of [mesh3D](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode.GLTFNode(bool,string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string).mesh3D 'DiGi\.GLTF\.Classes\.GLTFNode\.GLTFNode\(bool, string, string, DiGi\.Geometry\.Spatial\.Classes\.Mesh3D, DiGi\.Core\.Classes\.Color, double, string\)\.mesh3D') and [color](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode.GLTFNode(bool,string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string).color 'DiGi\.GLTF\.Classes\.GLTFNode\.GLTFNode\(bool, string, string, DiGi\.Geometry\.Spatial\.Classes\.Mesh3D, DiGi\.Core\.Classes\.Color, double, string\)\.color') and must not mutate them afterwards.

```csharp
internal GLTFNode(bool adopt, string? name, string? reference, DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D, DiGi.Core.Classes.Color? color, double opacity, string? properties);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(bool,string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string).adopt'></a>

`adopt` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Signature discriminator; always pass true\.

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(bool,string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the node\.

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(bool,string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique reference identifying the source object of the node\.

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(bool,string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string).mesh3D'></a>

`mesh3D` [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The triangulated [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') geometry adopted by the node\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(bool,string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string).color'></a>

`color` [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

The [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color') adopted by the node\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(bool,string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string).opacity'></a>

`opacity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The opacity of the node where 1 is fully opaque and 0 is fully transparent\.

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(bool,string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string).properties'></a>

`properties` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The JSON string with the properties of the source object\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(DiGi.GLTF.Classes.GLTFNode)'></a>

## GLTFNode\(GLTFNode\) Constructor

Initializes a new instance of the [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') class by copying an existing [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') instance\.

```csharp
public GLTFNode(DiGi.GLTF.Classes.GLTFNode? gLTFNode);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(DiGi.GLTF.Classes.GLTFNode).gLTFNode'></a>

`gLTFNode` [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode')

The [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') instance to copy from\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string)'></a>

## GLTFNode\(string, string, Mesh3D, Color, double, string\) Constructor

Initializes a new instance of the [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') class\.

```csharp
public GLTFNode(string? name, string? reference, DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D, DiGi.Core.Classes.Color? color, double opacity, string? properties);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the node\.

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique reference identifying the source object of the node\.

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string).mesh3D'></a>

`mesh3D` [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The triangulated [Mesh3D](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode.Mesh3D 'DiGi\.GLTF\.Classes\.GLTFNode\.Mesh3D') geometry of the node\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string).color'></a>

`color` [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

The [Color](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode.Color 'DiGi\.GLTF\.Classes\.GLTFNode\.Color') used to render the node\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string).opacity'></a>

`opacity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The opacity of the node where 1 is fully opaque and 0 is fully transparent\.

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(string,string,DiGi.Geometry.Spatial.Classes.Mesh3D,DiGi.Core.Classes.Color,double,string).properties'></a>

`properties` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The JSON string with the properties of the source object displayed in the properties panel\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(System.Text.Json.Nodes.JsonObject)'></a>

## GLTFNode\(JsonObject\) Constructor

Initializes a new instance of the [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public GLTFNode(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFNode.GLTFNode(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the node\. This value can be null\.
### Properties

<a name='DiGi.GLTF.Classes.GLTFNode.Color'></a>

## GLTFNode\.Color Property

Gets the [Color](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode.Color 'DiGi\.GLTF\.Classes\.GLTFNode\.Color') used to render the node\.

```csharp
public DiGi.Core.Classes.Color? Color { get; }
```

#### Property Value
[DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

<a name='DiGi.GLTF.Classes.GLTFNode.Color_Direct'></a>

## GLTFNode\.Color\_Direct Property

Gets the [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color') of the node without cloning\.

Performance path for large scene generation: the returned instance must not be mutated.

```csharp
internal DiGi.Core.Classes.Color? Color_Direct { internal get; }
```

#### Property Value
[DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

<a name='DiGi.GLTF.Classes.GLTFNode.Mesh3D'></a>

## GLTFNode\.Mesh3D Property

Gets the triangulated [Mesh3D](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode.Mesh3D 'DiGi\.GLTF\.Classes\.GLTFNode\.Mesh3D') geometry of the node\.

```csharp
public DiGi.Geometry.Spatial.Classes.Mesh3D? Mesh3D { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

<a name='DiGi.GLTF.Classes.GLTFNode.Mesh3D_Direct'></a>

## GLTFNode\.Mesh3D\_Direct Property

Gets the triangulated [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') geometry of the node without cloning\.

Performance path for large scene generation: the returned instance must not be mutated.

```csharp
internal DiGi.Geometry.Spatial.Classes.Mesh3D? Mesh3D_Direct { internal get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

<a name='DiGi.GLTF.Classes.GLTFNode.Name'></a>

## GLTFNode\.Name Property

Gets the display name of the node\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GLTF.Classes.GLTFNode.Opacity'></a>

## GLTFNode\.Opacity Property

Gets the opacity of the node where 1 is fully opaque and 0 is fully transparent\.

```csharp
public double Opacity { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GLTF.Classes.GLTFNode.Properties'></a>

## GLTFNode\.Properties Property

Gets the JSON string with the properties of the source object displayed in the properties panel\.

```csharp
public string? Properties { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GLTF.Classes.GLTFNode.Reference'></a>

## GLTFNode\.Reference Property

Gets the unique reference identifying the source object of the node\.

```csharp
public string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GLTF.Classes.GLTFNodeConverter_TSerializableObject_'></a>

## GLTFNodeConverter\<TSerializableObject\> Class

Convenience base class for [IGLTFNodeConverter](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFNodeConverter 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter') implementations handling a single domain type\.

Derive from this class in the consuming project, implement [Convert\(TSerializableObject, double\)](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNodeConverter_TSerializableObject_.Convert(TSerializableObject,double) 'DiGi\.GLTF\.Classes\.GLTFNodeConverter\<TSerializableObject\>\.Convert\(TSerializableObject, double\)') and register the converter (see [Register\(IGLTFNodeConverter\)](DiGi.GLTF.md#DiGi.GLTF.Modify.Register(DiGi.GLTF.Interfaces.IGLTFNodeConverter) 'DiGi\.GLTF\.Modify\.Register\(DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter\)')).

```csharp
public abstract class GLTFNodeConverter<TSerializableObject> : DiGi.GLTF.Interfaces.IGLTFNodeConverter, DiGi.GLTF.Interfaces.IGLTFObject, DiGi.Core.Interfaces.IObject
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.GLTF.Classes.GLTFNodeConverter_TSerializableObject_.TSerializableObject'></a>

`TSerializableObject`

The domain type handled by the converter\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GLTFNodeConverter\<TSerializableObject\>

Implements [IGLTFNodeConverter](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFNodeConverter 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter'), [IGLTFObject](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFObject 'DiGi\.GLTF\.Interfaces\.IGLTFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Methods

<a name='DiGi.GLTF.Classes.GLTFNodeConverter_TSerializableObject_.CanConvert(DiGi.Core.Interfaces.ISerializableObject)'></a>

## GLTFNodeConverter\<TSerializableObject\>\.CanConvert\(ISerializableObject\) Method

Determines whether this converter can convert the specified object\.

```csharp
public bool CanConvert(DiGi.Core.Interfaces.ISerializableObject serializableObject);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFNodeConverter_TSerializableObject_.CanConvert(DiGi.Core.Interfaces.ISerializableObject).serializableObject'></a>

`serializableObject` [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The domain object to be checked\.

Implements [CanConvert\(ISerializableObject\)](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFNodeConverter.CanConvert(DiGi.Core.Interfaces.ISerializableObject) 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter\.CanConvert\(DiGi\.Core\.Interfaces\.ISerializableObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object is a [TSerializableObject](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNodeConverter_TSerializableObject_.TSerializableObject 'DiGi\.GLTF\.Classes\.GLTFNodeConverter\<TSerializableObject\>\.TSerializableObject'); otherwise, false\.

<a name='DiGi.GLTF.Classes.GLTFNodeConverter_TSerializableObject_.Convert(DiGi.Core.Interfaces.ISerializableObject,double)'></a>

## GLTFNodeConverter\<TSerializableObject\>\.Convert\(ISerializableObject, double\) Method

Converts the specified object into [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') instances holding geometry in world coordinates\.

```csharp
public System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFNode>? Convert(DiGi.Core.Interfaces.ISerializableObject serializableObject, double tolerance);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFNodeConverter_TSerializableObject_.Convert(DiGi.Core.Interfaces.ISerializableObject,double).serializableObject'></a>

`serializableObject` [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The domain object to be converted\.

<a name='DiGi.GLTF.Classes.GLTFNodeConverter_TSerializableObject_.Convert(DiGi.Core.Interfaces.ISerializableObject,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during triangulation\.

Implements [Convert\(ISerializableObject, double\)](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFNodeConverter.Convert(DiGi.Core.Interfaces.ISerializableObject,double) 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter\.Convert\(DiGi\.Core\.Interfaces\.ISerializableObject, double\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') instances, or null if the object cannot be converted\.

<a name='DiGi.GLTF.Classes.GLTFNodeConverter_TSerializableObject_.Convert(TSerializableObject,double)'></a>

## GLTFNodeConverter\<TSerializableObject\>\.Convert\(TSerializableObject, double\) Method

Converts the specified [TSerializableObject](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNodeConverter_TSerializableObject_.TSerializableObject 'DiGi\.GLTF\.Classes\.GLTFNodeConverter\<TSerializableObject\>\.TSerializableObject') into [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') instances holding geometry in world coordinates\.

```csharp
public abstract System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFNode>? Convert(TSerializableObject serializableObject, double tolerance);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFNodeConverter_TSerializableObject_.Convert(TSerializableObject,double).serializableObject'></a>

`serializableObject` [TSerializableObject](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNodeConverter_TSerializableObject_.TSerializableObject 'DiGi\.GLTF\.Classes\.GLTFNodeConverter\<TSerializableObject\>\.TSerializableObject')

The domain object to be converted\.

<a name='DiGi.GLTF.Classes.GLTFNodeConverter_TSerializableObject_.Convert(TSerializableObject,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during triangulation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') instances, or null if the object cannot be converted\.

<a name='DiGi.GLTF.Classes.GLTFScene'></a>

## GLTFScene Class

Represents a renderable scene holding [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') objects, light configuration and camera position\.

All node geometry is expressed in local coordinates around the origin (0, 0, 0). The original world offset removed from the geometry is stored in [ReferencePoint](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene.ReferencePoint 'DiGi\.GLTF\.Classes\.GLTFScene\.ReferencePoint') to avoid floating-point precision issues in WebGL rendering of GIS coordinates.

```csharp
public class GLTFScene : DiGi.Core.Classes.SerializableObject, DiGi.GLTF.Interfaces.IGLTFSerializableObject, DiGi.GLTF.Interfaces.IGLTFObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → GLTFScene

Implements [IGLTFSerializableObject](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFSerializableObject 'DiGi\.GLTF\.Interfaces\.IGLTFSerializableObject'), [IGLTFObject](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFObject 'DiGi\.GLTF\.Interfaces\.IGLTFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(bool,string,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFNode_,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera)'></a>

## GLTFScene\(bool, string, Point3D, List\<GLTFNode\>, List\<GLTFLight\>, GLTFCamera\) Constructor

Initializes a new instance of the [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') class adopting the given instances without cloning\.

Performance path for large scene generation: the caller transfers ownership of all provided instances and must not mutate them afterwards.

```csharp
internal GLTFScene(bool adopt, string? name, DiGi.Geometry.Spatial.Classes.Point3D? referencePoint, System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFNode>? nodes, System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFLight>? lights, DiGi.GLTF.Classes.GLTFCamera? camera);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(bool,string,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFNode_,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera).adopt'></a>

`adopt` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Signature discriminator; always pass true\.

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(bool,string,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFNode_,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the scene\.

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(bool,string,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFNode_,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera).referencePoint'></a>

`referencePoint` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') world offset adopted by the scene\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(bool,string,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFNode_,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera).nodes'></a>

`nodes` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') list adopted by the scene\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(bool,string,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFNode_,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera).lights'></a>

`lights` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The [GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight') list adopted by the scene\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(bool,string,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFNode_,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera).camera'></a>

`camera` [GLTFCamera](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera 'DiGi\.GLTF\.Classes\.GLTFCamera')

The [GLTFCamera](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera 'DiGi\.GLTF\.Classes\.GLTFCamera') adopted by the scene\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(DiGi.GLTF.Classes.GLTFScene)'></a>

## GLTFScene\(GLTFScene\) Constructor

Initializes a new instance of the [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') class by copying an existing [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') instance\.

```csharp
public GLTFScene(DiGi.GLTF.Classes.GLTFScene? gLTFScene);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(DiGi.GLTF.Classes.GLTFScene).gLTFScene'></a>

`gLTFScene` [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene')

The [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') instance to copy from\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(string,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFNode_,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera)'></a>

## GLTFScene\(string, Point3D, IEnumerable\<GLTFNode\>, IEnumerable\<GLTFLight\>, GLTFCamera\) Constructor

Initializes a new instance of the [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') class\.

```csharp
public GLTFScene(string? name, DiGi.Geometry.Spatial.Classes.Point3D? referencePoint, System.Collections.Generic.IEnumerable<DiGi.GLTF.Classes.GLTFNode>? nodes, System.Collections.Generic.IEnumerable<DiGi.GLTF.Classes.GLTFLight>? lights, DiGi.GLTF.Classes.GLTFCamera? camera);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(string,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFNode_,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the scene\.

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(string,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFNode_,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera).referencePoint'></a>

`referencePoint` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') world offset removed from the node geometry during conversion to local coordinates\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(string,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFNode_,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera).nodes'></a>

`nodes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') objects to be displayed\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(string,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFNode_,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera).lights'></a>

`lights` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight') configuration of the scene\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(string,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFNode_,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera).camera'></a>

`camera` [GLTFCamera](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera 'DiGi\.GLTF\.Classes\.GLTFCamera')

The [GLTFCamera](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera 'DiGi\.GLTF\.Classes\.GLTFCamera') of the scene\. This value can be null\.

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(System.Text.Json.Nodes.JsonObject)'></a>

## GLTFScene\(JsonObject\) Constructor

Initializes a new instance of the [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public GLTFScene(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GLTF.Classes.GLTFScene.GLTFScene(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the scene\. This value can be null\.
### Properties

<a name='DiGi.GLTF.Classes.GLTFScene.Camera'></a>

## GLTFScene\.Camera Property

Gets the [GLTFCamera](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera 'DiGi\.GLTF\.Classes\.GLTFCamera') of the scene\.

```csharp
public DiGi.GLTF.Classes.GLTFCamera? Camera { get; }
```

#### Property Value
[GLTFCamera](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera 'DiGi\.GLTF\.Classes\.GLTFCamera')

<a name='DiGi.GLTF.Classes.GLTFScene.Lights'></a>

## GLTFScene\.Lights Property

Gets the [GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight') configuration of the scene\.

```csharp
public System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFLight>? Lights { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.GLTF.Classes.GLTFScene.Name'></a>

## GLTFScene\.Name Property

Gets the display name of the scene\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GLTF.Classes.GLTFScene.Nodes'></a>

## GLTFScene\.Nodes Property

Gets the [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') objects to be displayed\.

```csharp
public System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFNode>? Nodes { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.GLTF.Classes.GLTFScene.Nodes_Direct'></a>

## GLTFScene\.Nodes\_Direct Property

Gets the [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') list of the scene without cloning\.

Performance path for large scene generation: the returned list and its items must not be mutated.

```csharp
internal System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFNode>? Nodes_Direct { internal get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.GLTF.Classes.GLTFScene.ReferencePoint'></a>

## GLTFScene\.ReferencePoint Property

Gets the [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') world offset removed from the node geometry during conversion to local coordinates\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? ReferencePoint { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')