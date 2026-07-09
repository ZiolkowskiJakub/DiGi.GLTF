#### [DiGi\.GLTF](DiGi.GLTF.Overview.md 'DiGi\.GLTF\.Overview')

## DiGi\.GLTF Namespace
### Classes

<a name='DiGi.GLTF.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.GLTF.Convert.ToGLTF(thisDiGi.Core.Classes.Color,double)'></a>

## Convert\.ToGLTF\(this Color, double\) Method

Converts a [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color') and opacity to a SharpGLTF [SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder')\.

```csharp
public static SharpGLTF.Materials.MaterialBuilder ToGLTF(this DiGi.Core.Classes.Color? color, double opacity=1.0);
```
#### Parameters

<a name='DiGi.GLTF.Convert.ToGLTF(thisDiGi.Core.Classes.Color,double).color'></a>

`color` [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

The [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color') used as the base color of the material\. If this value is null, white is used\.

<a name='DiGi.GLTF.Convert.ToGLTF(thisDiGi.Core.Classes.Color,double).opacity'></a>

`opacity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The opacity of the material where 1 is fully opaque and 0 is fully transparent\.

#### Returns
[SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder')  
A double\-sided [SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder') with the given base color and alpha mode derived from the opacity\.

<a name='DiGi.GLTF.Convert.ToGLTF(thisDiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Convert\.ToGLTF\(this Point3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instance to a [SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')\.

```csharp
public static System.Nullable<SharpGLTF.Geometry.VertexTypes.VertexPosition> ToGLTF(this DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.GLTF.Convert.ToGLTF(thisDiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The source [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to convert\. This value can be null\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
A [SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition') representing the point in 3D space, or null if the provided [point3D](DiGi.GLTF.md#DiGi.GLTF.Convert.ToGLTF(thisDiGi.Geometry.Spatial.Classes.Point3D).point3D 'DiGi\.GLTF\.Convert\.ToGLTF\(this DiGi\.Geometry\.Spatial\.Classes\.Point3D\)\.point3D') is null\.

<a name='DiGi.GLTF.Convert.ToGLTF(thisDiGi.Geometry.Visual.Core.Interfaces.IAppearance)'></a>

## Convert\.ToGLTF\(this IAppearance\) Method

Converts an [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.iappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance') instance to a SharpGLTF [SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder')\.

```csharp
public static SharpGLTF.Materials.MaterialBuilder? ToGLTF(this DiGi.Geometry.Visual.Core.Interfaces.IAppearance appearance);
```
#### Parameters

<a name='DiGi.GLTF.Convert.ToGLTF(thisDiGi.Geometry.Visual.Core.Interfaces.IAppearance).appearance'></a>

`appearance` [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.iappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance')

The visual appearance properties for a geometry object\. This parameter can be null\.

#### Returns
[SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder')  
A [SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder') representing the material definition if the provided appearance is not null; otherwise, null\.

<a name='DiGi.GLTF.Convert.ToGLTF(thisDiGi.Geometry.Visual.Core.Interfaces.IVisualObject)'></a>

## Convert\.ToGLTF\(this IVisualObject\) Method

Converts a visual object into a GLTF mesh builder, extracting its geometry and appearance properties to create a 3D representation\.

```csharp
public static SharpGLTF.Geometry.MeshBuilder<SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1>? ToGLTF(this DiGi.Geometry.Visual.Core.Interfaces.IVisualObject? visualObject);
```
#### Parameters

<a name='DiGi.GLTF.Convert.ToGLTF(thisDiGi.Geometry.Visual.Core.Interfaces.IVisualObject).visualObject'></a>

`visualObject` [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.ivisualobject 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject')

The visual object to be converted\. This parameter can be null\.

#### Returns
[SharpGLTF\.Geometry\.MeshBuilder&lt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')  
A [SharpGLTF\.Geometry\.MeshBuilder&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2') containing the generated GLTF mesh data and materials, or null if the [visualObject](DiGi.GLTF.md#DiGi.GLTF.Convert.ToGLTF(thisDiGi.Geometry.Visual.Core.Interfaces.IVisualObject).visualObject 'DiGi\.GLTF\.Convert\.ToGLTF\(this DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\)\.visualObject') is null or lacks a valid visual representation\.

<a name='DiGi.GLTF.Convert.ToGLTF(thisDiGi.GLTF.Classes.GLTFScene)'></a>

## Convert\.ToGLTF\(this GLTFScene\) Method

Converts a [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') to a SharpGLTF [SharpGLTF\.Scenes\.SceneBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.scenes.scenebuilder 'SharpGLTF\.Scenes\.SceneBuilder')\.

Each [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') becomes a rigid mesh named after its reference. The serialized properties of the source object are attached as glTF extras so they can be displayed in a properties panel by the viewer.

```csharp
public static SharpGLTF.Scenes.SceneBuilder? ToGLTF(this DiGi.GLTF.Classes.GLTFScene? gLTFScene);
```
#### Parameters

<a name='DiGi.GLTF.Convert.ToGLTF(thisDiGi.GLTF.Classes.GLTFScene).gLTFScene'></a>

`gLTFScene` [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene')

The [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') to be converted\. This value can be null\.

#### Returns
[SharpGLTF\.Scenes\.SceneBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.scenes.scenebuilder 'SharpGLTF\.Scenes\.SceneBuilder')  
A [SharpGLTF\.Scenes\.SceneBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.scenes.scenebuilder 'SharpGLTF\.Scenes\.SceneBuilder') holding the scene geometry, or null if [gLTFScene](DiGi.GLTF.md#DiGi.GLTF.Convert.ToGLTF(thisDiGi.GLTF.Classes.GLTFScene).gLTFScene 'DiGi\.GLTF\.Convert\.ToGLTF\(this DiGi\.GLTF\.Classes\.GLTFScene\)\.gLTFScene') is null\.

<a name='DiGi.GLTF.Convert.ToGLTF_GLTFNodes(thisDiGi.Core.Interfaces.ISerializableObject,double)'></a>

## Convert\.ToGLTF\_GLTFNodes\(this ISerializableObject, double\) Method

Converts the specified [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') into [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') instances holding geometry in world coordinates\.

The registered [IGLTFNodeConverter](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFNodeConverter 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter') instances are consulted first (in registration order), keeping the engine open for extension: consuming projects plug in converters for their domain types without modifying this method. Built-in fallbacks handle [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') pass-through and raw [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') geometry.

```csharp
public static System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFNode>? ToGLTF_GLTFNodes(this DiGi.Core.Interfaces.ISerializableObject? serializableObject, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.GLTF.Convert.ToGLTF_GLTFNodes(thisDiGi.Core.Interfaces.ISerializableObject,double).serializableObject'></a>

`serializableObject` [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The object to be converted\. This value can be null\.

<a name='DiGi.GLTF.Convert.ToGLTF_GLTFNodes(thisDiGi.Core.Interfaces.ISerializableObject,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during triangulation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') instances, or null if the object is null or no converter handles it\.

<a name='DiGi.GLTF.Convert.ToSystem_Bytes(thisDiGi.GLTF.Classes.GLTFScene)'></a>

## Convert\.ToSystem\_Bytes\(this GLTFScene\) Method

Converts the specified [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') into a byte array representing a binary glTF \(\.glb\) file\.

```csharp
public static byte[]? ToSystem_Bytes(this DiGi.GLTF.Classes.GLTFScene? gLTFScene);
```
#### Parameters

<a name='DiGi.GLTF.Convert.ToSystem_Bytes(thisDiGi.GLTF.Classes.GLTFScene).gLTFScene'></a>

`gLTFScene` [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene')

The [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') instance to convert\. This value can be null\.

#### Returns
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
A byte array containing the GLB data if the conversion is successful and the input is not null; otherwise, null\.

<a name='DiGi.GLTF.Convert.ToSystem_Bytes(thisDiGi.GLTF.Classes.GLTFScene,bool)'></a>

## Convert\.ToSystem\_Bytes\(this GLTFScene, bool\) Method

Converts the specified [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') into a byte array representing a binary glTF \(\.glb\) file, optionally batching the node geometry\.

When [batched](DiGi.GLTF.md#DiGi.GLTF.Convert.ToSystem_Bytes(thisDiGi.GLTF.Classes.GLTFScene,bool).batched 'DiGi\.GLTF\.Convert\.ToSystem\_Bytes\(this DiGi\.GLTF\.Classes\.GLTFScene, bool\)\.batched') is true, all nodes are merged into one draw unit per alpha mode (see [GLTFBatches\(this GLTFScene, List&lt;GLTFBatchEntry&gt;\)](DiGi.GLTF.md#DiGi.GLTF.Create.GLTFBatches(thisDiGi.GLTF.Classes.GLTFScene,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFBatchEntry_) 'DiGi\.GLTF\.Create\.GLTFBatches\(this DiGi\.GLTF\.Classes\.GLTFScene, System\.Collections\.Generic\.List\<DiGi\.GLTF\.Classes\.GLTFBatchEntry\>\)')): per-object styling is baked into vertex colors, per-object identity is encoded in the _OBJECTID vertex attribute and the object identity map is stored in the scene extras. This reduces thousands of WebGL draw calls to one or two.

```csharp
public static byte[]? ToSystem_Bytes(this DiGi.GLTF.Classes.GLTFScene? gLTFScene, bool batched);
```
#### Parameters

<a name='DiGi.GLTF.Convert.ToSystem_Bytes(thisDiGi.GLTF.Classes.GLTFScene,bool).gLTFScene'></a>

`gLTFScene` [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene')

The [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') instance to convert\. This value can be null\.

<a name='DiGi.GLTF.Convert.ToSystem_Bytes(thisDiGi.GLTF.Classes.GLTFScene,bool).batched'></a>

`batched` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the node geometry is merged into batched draw units\.

#### Returns
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
A byte array containing the GLB data, or null if the scene is null or has no geometry\.

<a name='DiGi.GLTF.Convert.ToSystem_Bytes(thisSharpGLTF.Scenes.SceneBuilder)'></a>

## Convert\.ToSystem\_Bytes\(this SceneBuilder\) Method

Converts the specified [SharpGLTF\.Scenes\.SceneBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.scenes.scenebuilder 'SharpGLTF\.Scenes\.SceneBuilder') instance into a byte array representing a binary glTF \(\.glb\) file\.

```csharp
public static byte[]? ToSystem_Bytes(this SharpGLTF.Scenes.SceneBuilder? sceneBuilder);
```
#### Parameters

<a name='DiGi.GLTF.Convert.ToSystem_Bytes(thisSharpGLTF.Scenes.SceneBuilder).sceneBuilder'></a>

`sceneBuilder` [SharpGLTF\.Scenes\.SceneBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.scenes.scenebuilder 'SharpGLTF\.Scenes\.SceneBuilder')

The [SharpGLTF\.Scenes\.SceneBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.scenes.scenebuilder 'SharpGLTF\.Scenes\.SceneBuilder') instance to convert\. This value can be null\.

#### Returns
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
A byte array containing the GLB data if the conversion is successful and the input is not null; otherwise, null\.

<a name='DiGi.GLTF.Convert.ToSystem_Bytes(thisSystem.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFBatch_,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFBatchEntry_,string,DiGi.GLTF.Classes.GLTFScene)'></a>

## Convert\.ToSystem\_Bytes\(this IEnumerable\<GLTFBatch\>, IEnumerable\<GLTFBatchEntry\>, string, GLTFScene\) Method

Converts the specified [GLTFBatch](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFBatch 'DiGi\.GLTF\.Classes\.GLTFBatch') draw units into a byte array representing a binary glTF \(\.glb\) file\.

The binary buffer is packed directly from the batch arrays into a single allocation (positions as float32, colors as normalized unsigned byte RGBA, object ids as float32, indices as unsigned int32), minimizing memory overhead. The object identity map is written to the scene extras as objectMap so viewers can resolve picked object ids back to references and properties.

```csharp
public static byte[]? ToSystem_Bytes(this System.Collections.Generic.IEnumerable<DiGi.GLTF.Classes.GLTFBatch>? gLTFBatches, System.Collections.Generic.IEnumerable<DiGi.GLTF.Classes.GLTFBatchEntry>? gLTFBatchEntries, string? name=null, DiGi.GLTF.Classes.GLTFScene? gLTFScene_Configuration=null);
```
#### Parameters

<a name='DiGi.GLTF.Convert.ToSystem_Bytes(thisSystem.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFBatch_,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFBatchEntry_,string,DiGi.GLTF.Classes.GLTFScene).gLTFBatches'></a>

`gLTFBatches` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GLTFBatch](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFBatch 'DiGi\.GLTF\.Classes\.GLTFBatch')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [GLTFBatch](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFBatch 'DiGi\.GLTF\.Classes\.GLTFBatch') draw units to serialize\. This value can be null\.

<a name='DiGi.GLTF.Convert.ToSystem_Bytes(thisSystem.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFBatch_,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFBatchEntry_,string,DiGi.GLTF.Classes.GLTFScene).gLTFBatchEntries'></a>

`gLTFBatchEntries` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GLTFBatchEntry](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFBatchEntry 'DiGi\.GLTF\.Classes\.GLTFBatchEntry')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The identity entries of the batched objects; the list index of an entry is the object id encoded in the vertex attribute\. This value can be null\.

<a name='DiGi.GLTF.Convert.ToSystem_Bytes(thisSystem.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFBatch_,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFBatchEntry_,string,DiGi.GLTF.Classes.GLTFScene).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The optional display name of the scene\.

<a name='DiGi.GLTF.Convert.ToSystem_Bytes(thisSystem.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFBatch_,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFBatchEntry_,string,DiGi.GLTF.Classes.GLTFScene).gLTFScene_Configuration'></a>

`gLTFScene_Configuration` [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene')

The optional [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') whose configuration \(reference point, lights, camera\) is embedded in the scene extras as sceneConfiguration, making the GLB payload fully self\-describing for streamed delivery\. This value can be null\.

#### Returns
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
A byte array containing the GLB data, or null if [gLTFBatches](DiGi.GLTF.md#DiGi.GLTF.Convert.ToSystem_Bytes(thisSystem.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFBatch_,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFBatchEntry_,string,DiGi.GLTF.Classes.GLTFScene).gLTFBatches 'DiGi\.GLTF\.Convert\.ToSystem\_Bytes\(this System\.Collections\.Generic\.IEnumerable\<DiGi\.GLTF\.Classes\.GLTFBatch\>, System\.Collections\.Generic\.IEnumerable\<DiGi\.GLTF\.Classes\.GLTFBatchEntry\>, string, DiGi\.GLTF\.Classes\.GLTFScene\)\.gLTFBatches') is null or empty\.

<a name='DiGi.GLTF.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.GLTF.Create.GLTFBatches(thisDiGi.GLTF.Classes.GLTFScene,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFBatchEntry_)'></a>

## Create\.GLTFBatches\(this GLTFScene, List\<GLTFBatchEntry\>\) Method

Merges the node geometry of the specified [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') into a minimal set of [GLTFBatch](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFBatch 'DiGi\.GLTF\.Classes\.GLTFBatch') draw units \(one opaque, one alpha\-blended when required\)\.

Per-object styling is baked into vertex colors and per-object identity is encoded as a per-vertex object id, so thousands of objects render with one or two WebGL draw calls while remaining individually selectable. Each object occupies a contiguous vertex and index range recorded in its [GLTFBatchEntry](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFBatchEntry 'DiGi\.GLTF\.Classes\.GLTFBatchEntry').

```csharp
public static System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFBatch>? GLTFBatches(this DiGi.GLTF.Classes.GLTFScene? gLTFScene, out System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFBatchEntry> gLTFBatchEntries);
```
#### Parameters

<a name='DiGi.GLTF.Create.GLTFBatches(thisDiGi.GLTF.Classes.GLTFScene,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFBatchEntry_).gLTFScene'></a>

`gLTFScene` [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene')

The [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') to be batched\. This value can be null\.

<a name='DiGi.GLTF.Create.GLTFBatches(thisDiGi.GLTF.Classes.GLTFScene,System.Collections.Generic.List_DiGi.GLTF.Classes.GLTFBatchEntry_).gLTFBatchEntries'></a>

`gLTFBatchEntries` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GLTFBatchEntry](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFBatchEntry 'DiGi\.GLTF\.Classes\.GLTFBatchEntry')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The identity entries of all batched objects; the list index of an entry is the object id encoded in the vertex attribute\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GLTFBatch](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFBatch 'DiGi\.GLTF\.Classes\.GLTFBatch')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [GLTFBatch](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFBatch 'DiGi\.GLTF\.Classes\.GLTFBatch') instances \(opaque first, blended second when present\), or null if the scene has no valid geometry\.

<a name='DiGi.GLTF.Create.GLTFLights()'></a>

## Create\.GLTFLights\(\) Method

Creates the default [GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight') configuration: an ambient light and a directional sun light\.

The directional light is named Sun so its direction can be recalculated dynamically, for example to simulate the sun position during the day.

```csharp
public static System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFLight> GLTFLights();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight') instances with the default lighting configuration\.

<a name='DiGi.GLTF.Create.GLTFNode(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,string,string,DiGi.Core.Classes.Color,double,string,double)'></a>

## Create\.GLTFNode\(this IGeometry3D, string, string, Color, double, string, double\) Method

Creates a [GLTFNode\(this IGeometry3D, string, string, Color, double, string, double\)](DiGi.GLTF.md#DiGi.GLTF.Create.GLTFNode(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,string,string,DiGi.Core.Classes.Color,double,string,double) 'DiGi\.GLTF\.Create\.GLTFNode\(this DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D, string, string, DiGi\.Core\.Classes\.Color, double, string, double\)') from the specified [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') by triangulating the geometry and applying the given styling\.

```csharp
public static DiGi.GLTF.Classes.GLTFNode? GLTFNode(this DiGi.Geometry.Spatial.Interfaces.IGeometry3D? geometry3D, string? name=null, string? reference=null, DiGi.Core.Classes.Color? color=null, double opacity=1.0, string? properties=null, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.GLTF.Create.GLTFNode(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,string,string,DiGi.Core.Classes.Color,double,string,double).geometry3D'></a>

`geometry3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') to be converted\. This value can be null\.

<a name='DiGi.GLTF.Create.GLTFNode(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,string,string,DiGi.Core.Classes.Color,double,string,double).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the node\.

<a name='DiGi.GLTF.Create.GLTFNode(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,string,string,DiGi.Core.Classes.Color,double,string,double).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique reference identifying the source object of the node\.

<a name='DiGi.GLTF.Create.GLTFNode(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,string,string,DiGi.Core.Classes.Color,double,string,double).color'></a>

`color` [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

The [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color') used to render the node\. If this value is null, the default color is used\.

<a name='DiGi.GLTF.Create.GLTFNode(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,string,string,DiGi.Core.Classes.Color,double,string,double).opacity'></a>

`opacity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The opacity of the node where 1 is fully opaque and 0 is fully transparent\.

<a name='DiGi.GLTF.Create.GLTFNode(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,string,string,DiGi.Core.Classes.Color,double,string,double).properties'></a>

`properties` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The JSON string with the properties of the source object\. This value can be null\.

<a name='DiGi.GLTF.Create.GLTFNode(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,string,string,DiGi.Core.Classes.Color,double,string,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during triangulation\.

#### Returns
[GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode')  
A [GLTFNode\(this IGeometry3D, string, string, Color, double, string, double\)](DiGi.GLTF.md#DiGi.GLTF.Create.GLTFNode(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,string,string,DiGi.Core.Classes.Color,double,string,double) 'DiGi\.GLTF\.Create\.GLTFNode\(this DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D, string, string, DiGi\.Core\.Classes\.Color, double, string, double\)') holding the triangulated geometry, or null if the geometry is null or not supported\.

<a name='DiGi.GLTF.Create.GLTFScene(thisSystem.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.ISerializableObject_,string,DiGi.Core.Classes.Color,double)'></a>

## Create\.GLTFScene\(this IEnumerable\<ISerializableObject\>, string, Color, double\) Method

Creates a [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') from the specified [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') instances\.

Objects are converted through [ToGLTF\_GLTFNodes\(this ISerializableObject, double\)](DiGi.GLTF.md#DiGi.GLTF.Convert.ToGLTF_GLTFNodes(thisDiGi.Core.Interfaces.ISerializableObject,double) 'DiGi\.GLTF\.Convert\.ToGLTF\_GLTFNodes\(this DiGi\.Core\.Interfaces\.ISerializableObject, double\)'): registered [IGLTFNodeConverter](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFNodeConverter 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter') instances are consulted first, then [GLTFNode\(this IGeometry3D, string, string, Color, double, string, double\)](DiGi.GLTF.md#DiGi.GLTF.Create.GLTFNode(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,string,string,DiGi.Core.Classes.Color,double,string,double) 'DiGi\.GLTF\.Create\.GLTFNode\(this DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D, string, string, DiGi\.Core\.Classes\.Color, double, string, double\)') pass-through and raw [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') triangulation. Unsupported objects are skipped.

```csharp
public static DiGi.GLTF.Classes.GLTFScene? GLTFScene(this System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.ISerializableObject>? serializableObjects, string? name=null, DiGi.Core.Classes.Color? color=null, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.GLTF.Create.GLTFScene(thisSystem.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.ISerializableObject_,string,DiGi.Core.Classes.Color,double).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') instances to be displayed\. This value can be null\.

<a name='DiGi.GLTF.Create.GLTFScene(thisSystem.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.ISerializableObject_,string,DiGi.Core.Classes.Color,double).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the scene\.

<a name='DiGi.GLTF.Create.GLTFScene(thisSystem.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.ISerializableObject_,string,DiGi.Core.Classes.Color,double).color'></a>

`color` [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

The default [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color') applied to converted geometry\. This value can be null\.

<a name='DiGi.GLTF.Create.GLTFScene(thisSystem.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.ISerializableObject_,string,DiGi.Core.Classes.Color,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during triangulation\.

#### Returns
[GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene')  
A [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') with geometry translated to the local origin, or null if [serializableObjects](DiGi.GLTF.md#DiGi.GLTF.Create.GLTFScene(thisSystem.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.ISerializableObject_,string,DiGi.Core.Classes.Color,double).serializableObjects 'DiGi\.GLTF\.Create\.GLTFScene\(this System\.Collections\.Generic\.IEnumerable\<DiGi\.Core\.Interfaces\.ISerializableObject\>, string, DiGi\.Core\.Classes\.Color, double\)\.serializableObjects') is null\.

<a name='DiGi.GLTF.Create.GLTFScene(thisSystem.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFNode_,string,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera)'></a>

## Create\.GLTFScene\(this IEnumerable\<GLTFNode\>, string, IEnumerable\<GLTFLight\>, GLTFCamera\) Method

Creates a [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') from the specified [GLTFNode\(this IGeometry3D, string, string, Color, double, string, double\)](DiGi.GLTF.md#DiGi.GLTF.Create.GLTFNode(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,string,string,DiGi.Core.Classes.Color,double,string,double) 'DiGi\.GLTF\.Create\.GLTFNode\(this DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D, string, string, DiGi\.Core\.Classes\.Color, double, string, double\)') instances by translating all geometry to a local origin \(0, 0, 0\)\.

The reference point removed from the geometry is calculated from the combined bounding box (its centroid in X and Y, its minimum in Z) and stored in [ReferencePoint](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene.ReferencePoint 'DiGi\.GLTF\.Classes\.GLTFScene\.ReferencePoint') so the original world coordinates can be restored. This avoids floating-point precision issues in WebGL rendering of large GIS coordinates.

```csharp
public static DiGi.GLTF.Classes.GLTFScene? GLTFScene(this System.Collections.Generic.IEnumerable<DiGi.GLTF.Classes.GLTFNode>? gLTFNodes, string? name=null, System.Collections.Generic.IEnumerable<DiGi.GLTF.Classes.GLTFLight>? gLTFLights=null, DiGi.GLTF.Classes.GLTFCamera? gLTFCamera=null);
```
#### Parameters

<a name='DiGi.GLTF.Create.GLTFScene(thisSystem.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFNode_,string,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera).gLTFNodes'></a>

`gLTFNodes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [GLTFNode\(this IGeometry3D, string, string, Color, double, string, double\)](DiGi.GLTF.md#DiGi.GLTF.Create.GLTFNode(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,string,string,DiGi.Core.Classes.Color,double,string,double) 'DiGi\.GLTF\.Create\.GLTFNode\(this DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D, string, string, DiGi\.Core\.Classes\.Color, double, string, double\)') instances holding geometry in world coordinates\. This value can be null\.

<a name='DiGi.GLTF.Create.GLTFScene(thisSystem.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFNode_,string,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the scene\.

<a name='DiGi.GLTF.Create.GLTFScene(thisSystem.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFNode_,string,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera).gLTFLights'></a>

`gLTFLights` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The [GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight') configuration of the scene\. If this value is null, default lighting \(ambient light and directional sun light\) is created\.

<a name='DiGi.GLTF.Create.GLTFScene(thisSystem.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFNode_,string,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera).gLTFCamera'></a>

`gLTFCamera` [GLTFCamera](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera 'DiGi\.GLTF\.Classes\.GLTFCamera')

The [GLTFCamera](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera 'DiGi\.GLTF\.Classes\.GLTFCamera') of the scene\. If this value is null, a default automatically framing camera is created\.

#### Returns
[GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene')  
A [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') with geometry translated to the local origin, or null if [gLTFNodes](DiGi.GLTF.md#DiGi.GLTF.Create.GLTFScene(thisSystem.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFNode_,string,System.Collections.Generic.IEnumerable_DiGi.GLTF.Classes.GLTFLight_,DiGi.GLTF.Classes.GLTFCamera).gLTFNodes 'DiGi\.GLTF\.Create\.GLTFScene\(this System\.Collections\.Generic\.IEnumerable\<DiGi\.GLTF\.Classes\.GLTFNode\>, string, System\.Collections\.Generic\.IEnumerable\<DiGi\.GLTF\.Classes\.GLTFLight\>, DiGi\.GLTF\.Classes\.GLTFCamera\)\.gLTFNodes') is null\.

<a name='DiGi.GLTF.Create.InstanceBuilder(thisSharpGLTF.Scenes.SceneBuilder,DiGi.Geometry.Visual.Core.Interfaces.IVisualObject)'></a>

## Create\.InstanceBuilder\(this SceneBuilder, IVisualObject\) Method

Creates an [InstanceBuilder\(this SceneBuilder, IVisualObject\)](DiGi.GLTF.md#DiGi.GLTF.Create.InstanceBuilder(thisSharpGLTF.Scenes.SceneBuilder,DiGi.Geometry.Visual.Core.Interfaces.IVisualObject) 'DiGi\.GLTF\.Create\.InstanceBuilder\(this SharpGLTF\.Scenes\.SceneBuilder, DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\)') by converting a visual object to a GLTF mesh and adding it to the provided scene builder\.

```csharp
public static SharpGLTF.Scenes.InstanceBuilder? InstanceBuilder(this SharpGLTF.Scenes.SceneBuilder? sceneBuilder, DiGi.Geometry.Visual.Core.Interfaces.IVisualObject? visualObject);
```
#### Parameters

<a name='DiGi.GLTF.Create.InstanceBuilder(thisSharpGLTF.Scenes.SceneBuilder,DiGi.Geometry.Visual.Core.Interfaces.IVisualObject).sceneBuilder'></a>

`sceneBuilder` [SharpGLTF\.Scenes\.SceneBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.scenes.scenebuilder 'SharpGLTF\.Scenes\.SceneBuilder')

The [SceneBuilder\(this IEnumerable&lt;MeshBuilder&lt;VertexPosition,VertexColor1&gt;&gt;\)](DiGi.GLTF.md#DiGi.GLTF.Create.SceneBuilder(thisSystem.Collections.Generic.IEnumerable_SharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1__) 'DiGi\.GLTF\.Create\.SceneBuilder\(this System\.Collections\.Generic\.IEnumerable\<SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>\>\)') used to create the instance\. This parameter can be null\.

<a name='DiGi.GLTF.Create.InstanceBuilder(thisSharpGLTF.Scenes.SceneBuilder,DiGi.Geometry.Visual.Core.Interfaces.IVisualObject).visualObject'></a>

`visualObject` [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.ivisualobject 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject')

The [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.ivisualobject 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject') to be converted into a GLTF mesh and instanced\. This parameter can be null\.

#### Returns
[SharpGLTF\.Scenes\.InstanceBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.scenes.instancebuilder 'SharpGLTF\.Scenes\.InstanceBuilder')  
An [InstanceBuilder\(this SceneBuilder, IVisualObject\)](DiGi.GLTF.md#DiGi.GLTF.Create.InstanceBuilder(thisSharpGLTF.Scenes.SceneBuilder,DiGi.Geometry.Visual.Core.Interfaces.IVisualObject) 'DiGi\.GLTF\.Create\.InstanceBuilder\(this SharpGLTF\.Scenes\.SceneBuilder, DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\)') representing the created instance in the scene, or null if either the [sceneBuilder](DiGi.GLTF.md#DiGi.GLTF.Create.InstanceBuilder(thisSharpGLTF.Scenes.SceneBuilder,DiGi.Geometry.Visual.Core.Interfaces.IVisualObject).sceneBuilder 'DiGi\.GLTF\.Create\.InstanceBuilder\(this SharpGLTF\.Scenes\.SceneBuilder, DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\)\.sceneBuilder') or [visualObject](DiGi.GLTF.md#DiGi.GLTF.Create.InstanceBuilder(thisSharpGLTF.Scenes.SceneBuilder,DiGi.Geometry.Visual.Core.Interfaces.IVisualObject).visualObject 'DiGi\.GLTF\.Create\.InstanceBuilder\(this SharpGLTF\.Scenes\.SceneBuilder, DiGi\.Geometry\.Visual\.Core\.Interfaces\.IVisualObject\)\.visualObject') is null, or if the conversion to a GLTF mesh fails\.

<a name='DiGi.GLTF.Create.Mesh3D(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,double)'></a>

## Create\.Mesh3D\(this IGeometry3D, double\) Method

Creates a triangulated [Mesh3D\(this IGeometry3D, double\)](DiGi.GLTF.md#DiGi.GLTF.Create.Mesh3D(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,double) 'DiGi\.GLTF\.Create\.Mesh3D\(this DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D, double\)') from the specified [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')\.

Supported geometry types: [Mesh3D\(this IGeometry3D, double\)](DiGi.GLTF.md#DiGi.GLTF.Create.Mesh3D(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,double) 'DiGi\.GLTF\.Create\.Mesh3D\(this DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D, double\)'), [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') (including [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')), [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonal3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonal3D') (including [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')), [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFaceExtrusion](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalfaceextrusion 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFaceExtrusion') and [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron').

```csharp
public static DiGi.Geometry.Spatial.Classes.Mesh3D? Mesh3D(this DiGi.Geometry.Spatial.Interfaces.IGeometry3D? geometry3D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.GLTF.Create.Mesh3D(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,double).geometry3D'></a>

`geometry3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.igeometry3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D') to be triangulated\. This value can be null\.

<a name='DiGi.GLTF.Create.Mesh3D(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during triangulation\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')  
A [Mesh3D\(this IGeometry3D, double\)](DiGi.GLTF.md#DiGi.GLTF.Create.Mesh3D(thisDiGi.Geometry.Spatial.Interfaces.IGeometry3D,double) 'DiGi\.GLTF\.Create\.Mesh3D\(this DiGi\.Geometry\.Spatial\.Interfaces\.IGeometry3D, double\)') representing the triangulated geometry, or null if the geometry is null or not supported\.

<a name='DiGi.GLTF.Create.SceneBuilder(thisSystem.Collections.Generic.IEnumerable_SharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1__)'></a>

## Create\.SceneBuilder\(this IEnumerable\<MeshBuilder\<VertexPosition,VertexColor1\>\>\) Method

Creates a [SceneBuilder\(this IEnumerable&lt;MeshBuilder&lt;VertexPosition,VertexColor1&gt;&gt;\)](DiGi.GLTF.md#DiGi.GLTF.Create.SceneBuilder(thisSystem.Collections.Generic.IEnumerable_SharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1__) 'DiGi\.GLTF\.Create\.SceneBuilder\(this System\.Collections\.Generic\.IEnumerable\<SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>\>\)') and populates it by adding the provided collection of mesh builders as rigid meshes with identity transforms\.

```csharp
public static SharpGLTF.Scenes.SceneBuilder? SceneBuilder(this System.Collections.Generic.IEnumerable<SharpGLTF.Geometry.MeshBuilder<SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1>> meshBuilders);
```
#### Parameters

<a name='DiGi.GLTF.Create.SceneBuilder(thisSystem.Collections.Generic.IEnumerable_SharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1__).meshBuilders'></a>

`meshBuilders` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[SharpGLTF\.Geometry\.MeshBuilder&lt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The enumerable collection of [SharpGLTF\.Geometry\.MeshBuilder&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2') to be added to the scene\. This parameter can be null\.

#### Returns
[SharpGLTF\.Scenes\.SceneBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.scenes.scenebuilder 'SharpGLTF\.Scenes\.SceneBuilder')  
A new instance of [SceneBuilder\(this IEnumerable&lt;MeshBuilder&lt;VertexPosition,VertexColor1&gt;&gt;\)](DiGi.GLTF.md#DiGi.GLTF.Create.SceneBuilder(thisSystem.Collections.Generic.IEnumerable_SharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1__) 'DiGi\.GLTF\.Create\.SceneBuilder\(this System\.Collections\.Generic\.IEnumerable\<SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>\>\)') containing the provided meshes; returns an empty [SceneBuilder\(this IEnumerable&lt;MeshBuilder&lt;VertexPosition,VertexColor1&gt;&gt;\)](DiGi.GLTF.md#DiGi.GLTF.Create.SceneBuilder(thisSystem.Collections.Generic.IEnumerable_SharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1__) 'DiGi\.GLTF\.Create\.SceneBuilder\(this System\.Collections\.Generic\.IEnumerable\<SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>\>\)') if [meshBuilders](DiGi.GLTF.md#DiGi.GLTF.Create.SceneBuilder(thisSystem.Collections.Generic.IEnumerable_SharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1__).meshBuilders 'DiGi\.GLTF\.Create\.SceneBuilder\(this System\.Collections\.Generic\.IEnumerable\<SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>\>\)\.meshBuilders') is null\.

<a name='DiGi.GLTF.Create.GLTFBatchBuilder'></a>

## Create\.GLTFBatchBuilder Class

Accumulates packed vertex and index data for a single [GLTFBatch](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFBatch 'DiGi\.GLTF\.Classes\.GLTFBatch') using preallocated, exactly sized buffers\.

```csharp
private sealed class Create.GLTFBatchBuilder
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GLTFBatchBuilder

<a name='DiGi.GLTF.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Mesh3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_)'></a>

## Modify\.Add\(this MeshBuilder\<VertexPosition,VertexColor1\>, Mesh3D, MaterialBuilder, Nullable\<VertexColor1\>\) Method

Adds the geometry from a [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') instance to a [SharpGLTF\.Geometry\.MeshBuilder&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2') as a geometric primitive\.

```csharp
public static SharpGLTF.Geometry.PrimitiveBuilder<SharpGLTF.Materials.MaterialBuilder,SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1,SharpGLTF.Geometry.VertexTypes.VertexEmpty>? Add(this SharpGLTF.Geometry.MeshBuilder<SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1>? meshBuilder, DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D, SharpGLTF.Materials.MaterialBuilder? materialBuilder, System.Nullable<SharpGLTF.Geometry.VertexTypes.VertexColor1> vertexColor1_Override=null);
```
#### Parameters

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Mesh3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).meshBuilder'></a>

`meshBuilder` [SharpGLTF\.Geometry\.MeshBuilder&lt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')

The mesh builder used to create the primitive\. This parameter can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Mesh3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).mesh3D'></a>

`mesh3D` [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The source three\-dimensional mesh containing vertices and indices\. This parameter can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Mesh3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).materialBuilder'></a>

`materialBuilder` [SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder')

The material definition to be applied to the resulting geometric primitive\. This parameter can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Mesh3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).vertexColor1_Override'></a>

`vertexColor1_Override` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional override for the vertex color\. If this parameter is null, a default white color \(Vector4\.One\) is used\.

#### Returns
[SharpGLTF\.Geometry\.PrimitiveBuilder&lt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexEmpty](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexempty 'SharpGLTF\.Geometry\.VertexTypes\.VertexEmpty')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')  
A [SharpGLTF\.Geometry\.PrimitiveBuilder&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4') if the mesh was successfully added;
otherwise, null if any of the required parameters are null or if the geometry data is invalid\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Point3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_)'></a>

## Modify\.Add\(this MeshBuilder\<VertexPosition,VertexColor1\>, Point3D, MaterialBuilder, Nullable\<VertexColor1\>\) Method

Adds a single point to the mesh builder as a geometric primitive using the specified material and an optional vertex color override\.

```csharp
public static SharpGLTF.Geometry.PrimitiveBuilder<SharpGLTF.Materials.MaterialBuilder,SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1,SharpGLTF.Geometry.VertexTypes.VertexEmpty>? Add(this SharpGLTF.Geometry.MeshBuilder<SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1>? meshBuilder, DiGi.Geometry.Spatial.Classes.Point3D? point3D, SharpGLTF.Materials.MaterialBuilder? materialBuilder, System.Nullable<SharpGLTF.Geometry.VertexTypes.VertexColor1> vertexColor1_Override=null);
```
#### Parameters

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Point3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).meshBuilder'></a>

`meshBuilder` [SharpGLTF\.Geometry\.MeshBuilder&lt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')

The [SharpGLTF\.Geometry\.MeshBuilder&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2') instance used to construct the mesh\. This value can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Point3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).point3D'></a>

`point3D` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the position of the point in three\-dimensional space\. This value can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Point3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).materialBuilder'></a>

`materialBuilder` [SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder')

The [SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder') defining the material for the created primitive\. This value can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Point3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).vertexColor1_Override'></a>

`vertexColor1_Override` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional [SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1') to override the default vertex color\. If this value is null, a default white color is used\.

#### Returns
[SharpGLTF\.Geometry\.PrimitiveBuilder&lt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexEmpty](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexempty 'SharpGLTF\.Geometry\.VertexTypes\.VertexEmpty')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')  
A [SharpGLTF\.Geometry\.PrimitiveBuilder&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4') if the point was successfully added;
otherwise, null if [meshBuilder](DiGi.GLTF.md#DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Point3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).meshBuilder 'DiGi\.GLTF\.Modify\.Add\(this SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, DiGi\.Geometry\.Spatial\.Classes\.Point3D, SharpGLTF\.Materials\.MaterialBuilder, System\.Nullable\<SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>\)\.meshBuilder'), [point3D](DiGi.GLTF.md#DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Point3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).point3D 'DiGi\.GLTF\.Modify\.Add\(this SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, DiGi\.Geometry\.Spatial\.Classes\.Point3D, SharpGLTF\.Materials\.MaterialBuilder, System\.Nullable\<SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>\)\.point3D'), or [materialBuilder](DiGi.GLTF.md#DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Point3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).materialBuilder 'DiGi\.GLTF\.Modify\.Add\(this SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, DiGi\.Geometry\.Spatial\.Classes\.Point3D, SharpGLTF\.Materials\.MaterialBuilder, System\.Nullable\<SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>\)\.materialBuilder') is null,
or if the conversion of [point3D](DiGi.GLTF.md#DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Point3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).point3D 'DiGi\.GLTF\.Modify\.Add\(this SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, DiGi\.Geometry\.Spatial\.Classes\.Point3D, SharpGLTF\.Materials\.MaterialBuilder, System\.Nullable\<SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>\)\.point3D') to a GLTF vertex position fails\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Segment3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_)'></a>

## Modify\.Add\(this MeshBuilder\<VertexPosition,VertexColor1\>, Segment3D, MaterialBuilder, Nullable\<VertexColor1\>\) Method

Adds a three\-dimensional line segment to the specified mesh builder using a specific material and vertex color\.

```csharp
public static SharpGLTF.Geometry.PrimitiveBuilder<SharpGLTF.Materials.MaterialBuilder,SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1,SharpGLTF.Geometry.VertexTypes.VertexEmpty>? Add(this SharpGLTF.Geometry.MeshBuilder<SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1>? meshBuilder, DiGi.Geometry.Spatial.Classes.Segment3D? segment3D, SharpGLTF.Materials.MaterialBuilder? materialBuilder, System.Nullable<SharpGLTF.Geometry.VertexTypes.VertexColor1> vertexColor1_Override=null);
```
#### Parameters

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Segment3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).meshBuilder'></a>

`meshBuilder` [SharpGLTF\.Geometry\.MeshBuilder&lt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')

The [SharpGLTF\.Geometry\.MeshBuilder&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2') instance used to construct the mesh\. This value can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Segment3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).segment3D'></a>

`segment3D` [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') representing the line segment defined by two points in 3D space to be added\. This value can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Segment3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).materialBuilder'></a>

`materialBuilder` [SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder')

The [SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder') defining the material used for rendering the geometric primitive\. This value can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Segment3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).vertexColor1_Override'></a>

`vertexColor1_Override` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional [SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1') to override the default vertex color\. If this value is null, a default white color \(Vector4\.One\) is utilized\.

#### Returns
[SharpGLTF\.Geometry\.PrimitiveBuilder&lt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexEmpty](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexempty 'SharpGLTF\.Geometry\.VertexTypes\.VertexEmpty')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')  
A [SharpGLTF\.Geometry\.PrimitiveBuilder&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4') if the segment was successfully added; otherwise, null if any required parameter is null or if the segment points cannot be converted to [SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Triangle3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_)'></a>

## Modify\.Add\(this MeshBuilder\<VertexPosition,VertexColor1\>, Triangle3D, MaterialBuilder, Nullable\<VertexColor1\>\) Method

Adds a three\-dimensional triangle to the specified mesh builder using a provided material and an optional vertex color override\.

```csharp
public static SharpGLTF.Geometry.PrimitiveBuilder<SharpGLTF.Materials.MaterialBuilder,SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1,SharpGLTF.Geometry.VertexTypes.VertexEmpty>? Add(this SharpGLTF.Geometry.MeshBuilder<SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1>? meshBuilder, DiGi.Geometry.Spatial.Classes.Triangle3D? triangle3D, SharpGLTF.Materials.MaterialBuilder? materialBuilder, System.Nullable<SharpGLTF.Geometry.VertexTypes.VertexColor1> vertexColor1_Override=null);
```
#### Parameters

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Triangle3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).meshBuilder'></a>

`meshBuilder` [SharpGLTF\.Geometry\.MeshBuilder&lt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')

The [SharpGLTF\.Geometry\.MeshBuilder&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2') instance used to construct the mesh\. This value can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Triangle3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).triangle3D'></a>

`triangle3D` [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') geometry representing the triangle to be added to the mesh\. This value can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Triangle3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).materialBuilder'></a>

`materialBuilder` [SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder')

The [SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder') defining the material for the geometric primitive\. This value can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Triangle3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).vertexColor1_Override'></a>

`vertexColor1_Override` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional [SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1') override to apply to all vertices of the triangle\. If this value is null, a default color based on [System\.Numerics\.Vector4\.One](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector4.one 'System\.Numerics\.Vector4\.One') is used\.

#### Returns
[SharpGLTF\.Geometry\.PrimitiveBuilder&lt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexEmpty](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexempty 'SharpGLTF\.Geometry\.VertexTypes\.VertexEmpty')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')  
A [SharpGLTF\.Geometry\.PrimitiveBuilder&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4') if the triangle was successfully added;
otherwise, null if [meshBuilder](DiGi.GLTF.md#DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Triangle3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).meshBuilder 'DiGi\.GLTF\.Modify\.Add\(this SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, DiGi\.Geometry\.Spatial\.Classes\.Triangle3D, SharpGLTF\.Materials\.MaterialBuilder, System\.Nullable\<SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>\)\.meshBuilder'), [triangle3D](DiGi.GLTF.md#DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Triangle3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).triangle3D 'DiGi\.GLTF\.Modify\.Add\(this SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, DiGi\.Geometry\.Spatial\.Classes\.Triangle3D, SharpGLTF\.Materials\.MaterialBuilder, System\.Nullable\<SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>\)\.triangle3D'), or [materialBuilder](DiGi.GLTF.md#DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Triangle3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).materialBuilder 'DiGi\.GLTF\.Modify\.Add\(this SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, DiGi\.Geometry\.Spatial\.Classes\.Triangle3D, SharpGLTF\.Materials\.MaterialBuilder, System\.Nullable\<SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>\)\.materialBuilder') is null,
or if any vertex of the [triangle3D](DiGi.GLTF.md#DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Classes.Triangle3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).triangle3D 'DiGi\.GLTF\.Modify\.Add\(this SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, DiGi\.Geometry\.Spatial\.Classes\.Triangle3D, SharpGLTF\.Materials\.MaterialBuilder, System\.Nullable\<SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>\)\.triangle3D') cannot be converted to a [SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_,double)'></a>

## Modify\.Add\(this MeshBuilder\<VertexPosition,VertexColor1\>, IPolygonalFace3D, MaterialBuilder, Nullable\<VertexColor1\>, double\) Method

Adds a 3D polygonal face to the specified mesh builder as a geometric primitive\.

```csharp
public static SharpGLTF.Geometry.PrimitiveBuilder<SharpGLTF.Materials.MaterialBuilder,SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1,SharpGLTF.Geometry.VertexTypes.VertexEmpty>? Add(this SharpGLTF.Geometry.MeshBuilder<SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1>? meshBuilder, DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? polygonalFace3D, SharpGLTF.Materials.MaterialBuilder? materialBuilder, System.Nullable<SharpGLTF.Geometry.VertexTypes.VertexColor1> vertexColor1_Override=null, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_,double).meshBuilder'></a>

`meshBuilder` [SharpGLTF\.Geometry\.MeshBuilder&lt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')

The [SharpGLTF\.Geometry\.MeshBuilder&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2') instance to which the face is added\. This value can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_,double).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') representing the 3D polygonal face to add\. This value can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_,double).materialBuilder'></a>

`materialBuilder` [SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder')

The [SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder') defining the material for the resulting primitive\. This value can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_,double).vertexColor1_Override'></a>

`vertexColor1_Override` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional [SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1') override to apply to the vertices of the face\. Defaults to null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used when creating the mesh from the polygonal face\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[SharpGLTF\.Geometry\.PrimitiveBuilder&lt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexEmpty](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexempty 'SharpGLTF\.Geometry\.VertexTypes\.VertexEmpty')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')  
A [SharpGLTF\.Geometry\.PrimitiveBuilder&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4') for the added primitive if successful; otherwise, null if [meshBuilder](DiGi.GLTF.md#DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_,double).meshBuilder 'DiGi\.GLTF\.Modify\.Add\(this SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D, SharpGLTF\.Materials\.MaterialBuilder, System\.Nullable\<SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, double\)\.meshBuilder'), [polygonalFace3D](DiGi.GLTF.md#DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_,double).polygonalFace3D 'DiGi\.GLTF\.Modify\.Add\(this SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D, SharpGLTF\.Materials\.MaterialBuilder, System\.Nullable\<SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, double\)\.polygonalFace3D'), or [materialBuilder](DiGi.GLTF.md#DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_,double).materialBuilder 'DiGi\.GLTF\.Modify\.Add\(this SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D, SharpGLTF\.Materials\.MaterialBuilder, System\.Nullable\<SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, double\)\.materialBuilder') is null, or if the mesh creation fails\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_)'></a>

## Modify\.Add\(this MeshBuilder\<VertexPosition,VertexColor1\>, ISegmentable3D, MaterialBuilder, Nullable\<VertexColor1\>\) Method

Adds line segments from an [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D') source to a [SharpGLTF\.Geometry\.MeshBuilder&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2') as a geometric primitive\.

```csharp
public static SharpGLTF.Geometry.PrimitiveBuilder<SharpGLTF.Materials.MaterialBuilder,SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1,SharpGLTF.Geometry.VertexTypes.VertexEmpty>? Add(this SharpGLTF.Geometry.MeshBuilder<SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1>? meshBuilder, DiGi.Geometry.Spatial.Interfaces.ISegmentable3D? segmentable3D, SharpGLTF.Materials.MaterialBuilder? materialBuilder, System.Nullable<SharpGLTF.Geometry.VertexTypes.VertexColor1> vertexColor1_Override=null);
```
#### Parameters

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).meshBuilder'></a>

`meshBuilder` [SharpGLTF\.Geometry\.MeshBuilder&lt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.meshbuilder-2 'SharpGLTF\.Geometry\.MeshBuilder\`2')

The mesh builder instance used to create the primitive\. This parameter can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).segmentable3D'></a>

`segmentable3D` [DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.isegmentable3d 'DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D')

The 3D geometry source that provides the line segments to be added\. This parameter can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).materialBuilder'></a>

`materialBuilder` [SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder')

The material definition to be applied to the created primitive\. This parameter can be null\.

<a name='DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).vertexColor1_Override'></a>

`vertexColor1_Override` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional override for the vertex color of the lines\. If this value is null, a default white color \(Vector4\.One\) is used\.

#### Returns
[SharpGLTF\.Geometry\.PrimitiveBuilder&lt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Materials\.MaterialBuilder](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.materials.materialbuilder 'SharpGLTF\.Materials\.MaterialBuilder')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexPosition](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexposition 'SharpGLTF\.Geometry\.VertexTypes\.VertexPosition')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexColor1](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexcolor1 'SharpGLTF\.Geometry\.VertexTypes\.VertexColor1')[,](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')[SharpGLTF\.Geometry\.VertexTypes\.VertexEmpty](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.vertextypes.vertexempty 'SharpGLTF\.Geometry\.VertexTypes\.VertexEmpty')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4')  
A [SharpGLTF\.Geometry\.PrimitiveBuilder&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/sharpgltf.geometry.primitivebuilder-4 'SharpGLTF\.Geometry\.PrimitiveBuilder\`4') containing the generated line segments if successful;
otherwise, null if [meshBuilder](DiGi.GLTF.md#DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).meshBuilder 'DiGi\.GLTF\.Modify\.Add\(this SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D, SharpGLTF\.Materials\.MaterialBuilder, System\.Nullable\<SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>\)\.meshBuilder'), [segmentable3D](DiGi.GLTF.md#DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).segmentable3D 'DiGi\.GLTF\.Modify\.Add\(this SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D, SharpGLTF\.Materials\.MaterialBuilder, System\.Nullable\<SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>\)\.segmentable3D'), or [materialBuilder](DiGi.GLTF.md#DiGi.GLTF.Modify.Add(thisSharpGLTF.Geometry.MeshBuilder_SharpGLTF.Geometry.VertexTypes.VertexPosition,SharpGLTF.Geometry.VertexTypes.VertexColor1_,DiGi.Geometry.Spatial.Interfaces.ISegmentable3D,SharpGLTF.Materials.MaterialBuilder,System.Nullable_SharpGLTF.Geometry.VertexTypes.VertexColor1_).materialBuilder 'DiGi\.GLTF\.Modify\.Add\(this SharpGLTF\.Geometry\.MeshBuilder\<SharpGLTF\.Geometry\.VertexTypes\.VertexPosition,SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>, DiGi\.Geometry\.Spatial\.Interfaces\.ISegmentable3D, SharpGLTF\.Materials\.MaterialBuilder, System\.Nullable\<SharpGLTF\.Geometry\.VertexTypes\.VertexColor1\>\)\.materialBuilder') is null,
or if the segment data cannot be retrieved as a [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')\.

<a name='DiGi.GLTF.Modify.Register(DiGi.GLTF.Interfaces.IGLTFNodeConverter)'></a>

## Modify\.Register\(IGLTFNodeConverter\) Method

Registers the specified [IGLTFNodeConverter](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFNodeConverter 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter') so it is consulted by [ToGLTF\_GLTFNodes\(this ISerializableObject, double\)](DiGi.GLTF.md#DiGi.GLTF.Convert.ToGLTF_GLTFNodes(thisDiGi.Core.Interfaces.ISerializableObject,double) 'DiGi\.GLTF\.Convert\.ToGLTF\_GLTFNodes\(this DiGi\.Core\.Interfaces\.ISerializableObject, double\)')\.

Converters are consulted in registration order; the first converter whose CanConvert returns true wins, so register more specific converters before more general ones.

```csharp
public static bool Register(DiGi.GLTF.Interfaces.IGLTFNodeConverter? gLTFNodeConverter);
```
#### Parameters

<a name='DiGi.GLTF.Modify.Register(DiGi.GLTF.Interfaces.IGLTFNodeConverter).gLTFNodeConverter'></a>

`gLTFNodeConverter` [IGLTFNodeConverter](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFNodeConverter 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter')

The converter to register\. This value can be null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the converter was registered; otherwise, false\.

<a name='DiGi.GLTF.Modify.Register(System.Reflection.Assembly)'></a>

## Modify\.Register\(Assembly\) Method

Registers all [IGLTFNodeConverter](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFNodeConverter 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter') implementations with a public parameterless constructor found in the specified assembly\.

This enables plugin-like extensibility: a consuming project registers its assembly once at startup and any converter class added later is picked up without further registration code.

```csharp
public static int Register(System.Reflection.Assembly? assembly);
```
#### Parameters

<a name='DiGi.GLTF.Modify.Register(System.Reflection.Assembly).assembly'></a>

`assembly` [System\.Reflection\.Assembly](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.assembly 'System\.Reflection\.Assembly')

The assembly to scan\. This value can be null\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The number of converters registered\.

<a name='DiGi.GLTF.Modify.RegisteredGLTFNodeConverters()'></a>

## Modify\.RegisteredGLTFNodeConverters\(\) Method

Gets the currently registered [IGLTFNodeConverter](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFNodeConverter 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter') snapshot in registration order\.

```csharp
internal static System.Collections.Generic.List<DiGi.GLTF.Interfaces.IGLTFNodeConverter> RegisteredGLTFNodeConverters();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IGLTFNodeConverter](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFNodeConverter 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
An immutable snapshot of the registered converters\.

<a name='DiGi.GLTF.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.GLTF.Query.BoundingBox3D(thisDiGi.GLTF.Classes.GLTFNode)'></a>

## Query\.BoundingBox3D\(this GLTFNode\) Method

Calculates the axis\-aligned bounding box of the geometry held by the specified [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.BoundingBox3D? BoundingBox3D(this DiGi.GLTF.Classes.GLTFNode? gLTFNode);
```
#### Parameters

<a name='DiGi.GLTF.Query.BoundingBox3D(thisDiGi.GLTF.Classes.GLTFNode).gLTFNode'></a>

`gLTFNode` [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode')

The [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') to be evaluated\. This value can be null\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') of the node geometry, or null if the node or its mesh is null\.

<a name='DiGi.GLTF.Query.BoundingBox3D(thisDiGi.GLTF.Classes.GLTFScene)'></a>

## Query\.BoundingBox3D\(this GLTFScene\) Method

Calculates the combined axis\-aligned bounding box of all [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') geometry within the specified [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene')\.

The bounding box is expressed in the local coordinates of the scene, relative to its reference point.

```csharp
public static DiGi.Geometry.Spatial.Classes.BoundingBox3D? BoundingBox3D(this DiGi.GLTF.Classes.GLTFScene? gLTFScene);
```
#### Parameters

<a name='DiGi.GLTF.Query.BoundingBox3D(thisDiGi.GLTF.Classes.GLTFScene).gLTFScene'></a>

`gLTFScene` [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene')

The [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene') to be evaluated\. This value can be null\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') covering all node geometry, or null if the scene has no valid geometry\.