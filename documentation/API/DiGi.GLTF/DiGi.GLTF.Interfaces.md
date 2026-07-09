#### [DiGi\.GLTF](DiGi.GLTF.Overview.md 'DiGi\.GLTF\.Overview')

## DiGi\.GLTF\.Interfaces Namespace
### Interfaces

<a name='DiGi.GLTF.Interfaces.IGLTFNodeConverter'></a>

## IGLTFNodeConverter Interface

Defines a pluggable converter turning a domain [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') into generic [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') instances\.

Converters are registered with [Register\(IGLTFNodeConverter\)](DiGi.GLTF.md#DiGi.GLTF.Modify.Register(DiGi.GLTF.Interfaces.IGLTFNodeConverter) 'DiGi\.GLTF\.Modify\.Register\(DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter\)') (or via assembly scanning) and are consulted by [ToGLTF\_GLTFNodes\(this ISerializableObject, double\)](DiGi.GLTF.md#DiGi.GLTF.Convert.ToGLTF_GLTFNodes(thisDiGi.Core.Interfaces.ISerializableObject,double) 'DiGi\.GLTF\.Convert\.ToGLTF\_GLTFNodes\(this DiGi\.Core\.Interfaces\.ISerializableObject, double\)'). This keeps the engine open for extension and closed for modification: supporting a new domain type only requires a new converter class in the consuming project.

```csharp
public interface IGLTFNodeConverter : DiGi.GLTF.Interfaces.IGLTFObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [GLTFNodeConverter&lt;TSerializableObject&gt;](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNodeConverter_TSerializableObject_ 'DiGi\.GLTF\.Classes\.GLTFNodeConverter\<TSerializableObject\>')

Implements [IGLTFObject](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFObject 'DiGi\.GLTF\.Interfaces\.IGLTFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Methods

<a name='DiGi.GLTF.Interfaces.IGLTFNodeConverter.CanConvert(DiGi.Core.Interfaces.ISerializableObject)'></a>

## IGLTFNodeConverter\.CanConvert\(ISerializableObject\) Method

Determines whether this converter can convert the specified object\.

```csharp
bool CanConvert(DiGi.Core.Interfaces.ISerializableObject serializableObject);
```
#### Parameters

<a name='DiGi.GLTF.Interfaces.IGLTFNodeConverter.CanConvert(DiGi.Core.Interfaces.ISerializableObject).serializableObject'></a>

`serializableObject` [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The domain object to be checked\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if this converter handles the object; otherwise, false\.

<a name='DiGi.GLTF.Interfaces.IGLTFNodeConverter.Convert(DiGi.Core.Interfaces.ISerializableObject,double)'></a>

## IGLTFNodeConverter\.Convert\(ISerializableObject, double\) Method

Converts the specified object into [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') instances holding geometry in world coordinates\.

```csharp
System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFNode>? Convert(DiGi.Core.Interfaces.ISerializableObject serializableObject, double tolerance);
```
#### Parameters

<a name='DiGi.GLTF.Interfaces.IGLTFNodeConverter.Convert(DiGi.Core.Interfaces.ISerializableObject,double).serializableObject'></a>

`serializableObject` [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The domain object to be converted\.

<a name='DiGi.GLTF.Interfaces.IGLTFNodeConverter.Convert(DiGi.Core.Interfaces.ISerializableObject,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during triangulation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode') instances, or null if the object cannot be converted\.

<a name='DiGi.GLTF.Interfaces.IGLTFObject'></a>

## IGLTFObject Interface

Marker interface for all objects belonging to the DiGi\.GLTF project\.

```csharp
public interface IGLTFObject : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [GLTFCamera](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera 'DiGi\.GLTF\.Classes\.GLTFCamera')  
↳ [GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight')  
↳ [GLTFModel](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFModel 'DiGi\.GLTF\.Classes\.GLTFModel')  
↳ [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode')  
↳ [GLTFNodeConverter&lt;TSerializableObject&gt;](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNodeConverter_TSerializableObject_ 'DiGi\.GLTF\.Classes\.GLTFNodeConverter\<TSerializableObject\>')  
↳ [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene')  
↳ [IGLTFNodeConverter](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFNodeConverter 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter')  
↳ [IGLTFSerializableObject](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFSerializableObject 'DiGi\.GLTF\.Interfaces\.IGLTFSerializableObject')

Implements [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.GLTF.Interfaces.IGLTFSerializableObject'></a>

## IGLTFSerializableObject Interface

Marker interface for all serializable objects belonging to the DiGi\.GLTF project\.

```csharp
public interface IGLTFSerializableObject : DiGi.GLTF.Interfaces.IGLTFObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [GLTFCamera](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFCamera 'DiGi\.GLTF\.Classes\.GLTFCamera')  
↳ [GLTFLight](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFLight 'DiGi\.GLTF\.Classes\.GLTFLight')  
↳ [GLTFModel](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFModel 'DiGi\.GLTF\.Classes\.GLTFModel')  
↳ [GLTFNode](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFNode 'DiGi\.GLTF\.Classes\.GLTFNode')  
↳ [GLTFScene](DiGi.GLTF.Classes.md#DiGi.GLTF.Classes.GLTFScene 'DiGi\.GLTF\.Classes\.GLTFScene')

Implements [IGLTFObject](DiGi.GLTF.Interfaces.md#DiGi.GLTF.Interfaces.IGLTFObject 'DiGi\.GLTF\.Interfaces\.IGLTFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')