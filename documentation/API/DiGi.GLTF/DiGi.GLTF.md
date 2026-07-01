## DiGi\.GLTF Namespace
### Classes

<a name='DiGi.GLTF.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

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

<a name='DiGi.GLTF.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

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