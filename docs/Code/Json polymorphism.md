---
status: planted
dg-publish: true
tags:
  - code/dotNET
creation_date: 2024-05-21 10:42
definition: undefined
ms-learn-url: https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/polymorphism?pivots=dotnet-8-0
url: undefined
aliases:
---

|          |                                              |
| -------- | -------------------------------------------- |
| Homesite | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

> [!NOTE] Definition
> `VIEW[{definition}][text(renderMarkdown)]`


Beginning with .NET 7, `System.Text.Json` supports polymorphic type hierarchy serialization and deserialization with attribute annotations.

|Attribute|Description|
|---|---|
|[JsonDerivedTypeAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonderivedtypeattribute)|When placed on a type declaration, indicates that the specified subtype should be opted into polymorphic serialization. It also exposes the ability to specify a type discriminator.|
|[JsonPolymorphicAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonpolymorphicattribute)|When placed on a type declaration, indicates that the type should be serialized polymorphically. It also exposes various options to configure polymorphic serialization and deserialization for that type.|

### Customize the type discriminator name

The default property name for the type discriminator is `$type`. To customize the property name, use the [JsonPolymorphicAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonpolymorphicattribute) as shown in the following example:


```c#
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$discriminator")]
[JsonDerivedType(typeof(ThreeDimensionalPoint), typeDiscriminator: "3d")]
public class BasePoint
{
    public int X { get; set; }
    public int Y { get; set; }
}

public sealed class ThreeDimensionalPoint : BasePoint
{
    public int Z { get; set; }
}
```