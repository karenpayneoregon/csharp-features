<a name='assembly'></a>
# JsonCodeSamples

## Contents

- [AddressDetails](#T-JsonCodeSamples-Models-AddressDetails 'JsonCodeSamples.Models.AddressDetails')
  - [City](#P-JsonCodeSamples-Models-AddressDetails-City 'JsonCodeSamples.Models.AddressDetails.City')
  - [PostalCode](#P-JsonCodeSamples-Models-AddressDetails-PostalCode 'JsonCodeSamples.Models.AddressDetails.PostalCode')
  - [State](#P-JsonCodeSamples-Models-AddressDetails-State 'JsonCodeSamples.Models.AddressDetails.State')
  - [Street](#P-JsonCodeSamples-Models-AddressDetails-Street 'JsonCodeSamples.Models.AddressDetails.Street')
  - [ToString()](#M-JsonCodeSamples-Models-AddressDetails-ToString 'JsonCodeSamples.Models.AddressDetails.ToString')
- [Form1](#T-JsonCodeSamples-Form1 'JsonCodeSamples.Form1')
  - [#ctor()](#M-JsonCodeSamples-Form1-#ctor 'JsonCodeSamples.Form1.#ctor')
  - [components](#F-JsonCodeSamples-Form1-components 'JsonCodeSamples.Form1.components')
  - [Dispose(disposing)](#M-JsonCodeSamples-Form1-Dispose-System-Boolean- 'JsonCodeSamples.Form1.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-JsonCodeSamples-Form1-InitializeComponent 'JsonCodeSamples.Form1.InitializeComponent')
- [Gender](#T-JsonCodeSamples-Models-Gender 'JsonCodeSamples.Models.Gender')
  - [Female](#F-JsonCodeSamples-Models-Gender-Female 'JsonCodeSamples.Models.Gender.Female')
  - [Male](#F-JsonCodeSamples-Models-Gender-Male 'JsonCodeSamples.Models.Gender.Male')
  - [Other](#F-JsonCodeSamples-Models-Gender-Other 'JsonCodeSamples.Models.Gender.Other')
- [Helpers](#T-JsonCodeSamples-Classes-Helpers 'JsonCodeSamples.Classes.Helpers')
  - [JsonToListModel\`\`1(fileName)](#M-JsonCodeSamples-Classes-Helpers-JsonToListModel``1-System-String- 'JsonCodeSamples.Classes.Helpers.JsonToListModel``1(System.String)')
  - [JsonToModel\`\`1(fileName)](#M-JsonCodeSamples-Classes-Helpers-JsonToModel``1-System-String- 'JsonCodeSamples.Classes.Helpers.JsonToModel``1(System.String)')
  - [ModelListToJson\`\`1(list,fileName)](#M-JsonCodeSamples-Classes-Helpers-ModelListToJson``1-System-Collections-Generic-List{``0},System-String- 'JsonCodeSamples.Classes.Helpers.ModelListToJson``1(System.Collections.Generic.List{``0},System.String)')
  - [ModelToJson\`\`1(list,fileName)](#M-JsonCodeSamples-Classes-Helpers-ModelToJson``1-``0,System-String- 'JsonCodeSamples.Classes.Helpers.ModelToJson``1(``0,System.String)')
- [Mockups](#T-JsonCodeSamples-Models-Mockups 'JsonCodeSamples.Models.Mockups')
  - [ShippingInfoList()](#M-JsonCodeSamples-Models-Mockups-ShippingInfoList 'JsonCodeSamples.Models.Mockups.ShippingInfoList')
  - [ShippingInfoNestedList()](#M-JsonCodeSamples-Models-Mockups-ShippingInfoNestedList 'JsonCodeSamples.Models.Mockups.ShippingInfoNestedList')
  - [singleShipInfo()](#M-JsonCodeSamples-Models-Mockups-singleShipInfo 'JsonCodeSamples.Models.Mockups.singleShipInfo')
- [NewtonSettings](#T-JsonCodeSamples-Classes-NewtonSettings 'JsonCodeSamples.Classes.NewtonSettings')
  - [SettingsDefault()](#M-JsonCodeSamples-Classes-NewtonSettings-SettingsDefault 'JsonCodeSamples.Classes.NewtonSettings.SettingsDefault')
  - [SettingsIgnoreReferenceLooping()](#M-JsonCodeSamples-Classes-NewtonSettings-SettingsIgnoreReferenceLooping 'JsonCodeSamples.Classes.NewtonSettings.SettingsIgnoreReferenceLooping')
- [Person](#T-JsonCodeSamples-Models-Person 'JsonCodeSamples.Models.Person')
  - [firstname](#P-JsonCodeSamples-Models-Person-firstname 'JsonCodeSamples.Models.Person.firstname')
  - [gender](#P-JsonCodeSamples-Models-Person-gender 'JsonCodeSamples.Models.Person.gender')
  - [lastname](#P-JsonCodeSamples-Models-Person-lastname 'JsonCodeSamples.Models.Person.lastname')
- [Program](#T-JsonCodeSamples-Program 'JsonCodeSamples.Program')
  - [Main()](#M-JsonCodeSamples-Program-Main 'JsonCodeSamples.Program.Main')
- [Resources](#T-JsonCodeSamples-Properties-Resources 'JsonCodeSamples.Properties.Resources')
  - [Culture](#P-JsonCodeSamples-Properties-Resources-Culture 'JsonCodeSamples.Properties.Resources.Culture')
  - [ResourceManager](#P-JsonCodeSamples-Properties-Resources-ResourceManager 'JsonCodeSamples.Properties.Resources.ResourceManager')
- [ShippingInfo](#T-JsonCodeSamples-Models-ShippingInfo 'JsonCodeSamples.Models.ShippingInfo')
  - [#ctor()](#M-JsonCodeSamples-Models-ShippingInfo-#ctor 'JsonCodeSamples.Models.ShippingInfo.#ctor')
  - [AddressDetails](#P-JsonCodeSamples-Models-ShippingInfo-AddressDetails 'JsonCodeSamples.Models.ShippingInfo.AddressDetails')
  - [Id](#P-JsonCodeSamples-Models-ShippingInfo-Id 'JsonCodeSamples.Models.ShippingInfo.Id')
  - [SomethingNested](#P-JsonCodeSamples-Models-ShippingInfo-SomethingNested 'JsonCodeSamples.Models.ShippingInfo.SomethingNested')
  - [ToString()](#M-JsonCodeSamples-Models-ShippingInfo-ToString 'JsonCodeSamples.Models.ShippingInfo.ToString')
- [SomethingNested](#T-JsonCodeSamples-Models-SomethingNested 'JsonCodeSamples.Models.SomethingNested')
  - [Id](#P-JsonCodeSamples-Models-SomethingNested-Id 'JsonCodeSamples.Models.SomethingNested.Id')
  - [Value](#P-JsonCodeSamples-Models-SomethingNested-Value 'JsonCodeSamples.Models.SomethingNested.Value')

<a name='T-JsonCodeSamples-Models-AddressDetails'></a>
## AddressDetails `type`

##### Namespace

JsonCodeSamples.Models

##### Summary

For [Person](#T-JsonCodeSamples-Models-Person 'JsonCodeSamples.Models.Person')

<a name='P-JsonCodeSamples-Models-AddressDetails-City'></a>
### City `property`

##### Summary

City

<a name='P-JsonCodeSamples-Models-AddressDetails-PostalCode'></a>
### PostalCode `property`

##### Summary

Postal Code

<a name='P-JsonCodeSamples-Models-AddressDetails-State'></a>
### State `property`

##### Summary

State

<a name='P-JsonCodeSamples-Models-AddressDetails-Street'></a>
### Street `property`

##### Summary

Street

<a name='M-JsonCodeSamples-Models-AddressDetails-ToString'></a>
### ToString() `method`

##### Summary

For debugging

##### Returns



##### Parameters

This method has no parameters.

<a name='T-JsonCodeSamples-Form1'></a>
## Form1 `type`

##### Namespace

JsonCodeSamples

##### Summary

*Inherit from parent.*

<a name='M-JsonCodeSamples-Form1-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-JsonCodeSamples-Form1-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-JsonCodeSamples-Form1-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-JsonCodeSamples-Form1-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-JsonCodeSamples-Models-Gender'></a>
## Gender `type`

##### Namespace

JsonCodeSamples.Models

##### Summary

Gender type

<a name='F-JsonCodeSamples-Models-Gender-Female'></a>
### Female `constants`

##### Summary

Female

<a name='F-JsonCodeSamples-Models-Gender-Male'></a>
### Male `constants`

##### Summary

Male

<a name='F-JsonCodeSamples-Models-Gender-Other'></a>
### Other `constants`

##### Summary

Generic

<a name='T-JsonCodeSamples-Classes-Helpers'></a>
## Helpers `type`

##### Namespace

JsonCodeSamples.Classes

##### Summary

Provides serializing operation methods

<a name='M-JsonCodeSamples-Classes-Helpers-JsonToListModel``1-System-String-'></a>
### JsonToListModel\`\`1(fileName) `method`

##### Summary

List of T from file

##### Returns

[ValueTuple](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueTuple 'System.ValueTuple') of list and [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Read from file |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type to deserialize |

<a name='M-JsonCodeSamples-Classes-Helpers-JsonToModel``1-System-String-'></a>
### JsonToModel\`\`1(fileName) `method`

##### Summary

Read file, convert to TModel/>

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Read from file |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TModel | type to deserialize |

<a name='M-JsonCodeSamples-Classes-Helpers-ModelListToJson``1-System-Collections-Generic-List{``0},System-String-'></a>
### ModelListToJson\`\`1(list,fileName) `method`

##### Summary

Convert <see cref="TModel"/> to json file

##### Returns

[ValueTuple](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueTuple 'System.ValueTuple') of bool for success, [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') if a runtime exception is thrown

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.List{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{``0}') | List of TModel |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Save to file |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TModel | type to serialize |

<a name='M-JsonCodeSamples-Classes-Helpers-ModelToJson``1-``0,System-String-'></a>
### ModelToJson\`\`1(list,fileName) `method`

##### Summary

Saves TModel to a file

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [\`\`0](#T-``0 '``0') | List of TModel |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Save to file |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TModel | type to serialize |

<a name='T-JsonCodeSamples-Models-Mockups'></a>
## Mockups `type`

##### Namespace

JsonCodeSamples.Models

##### Summary

Place mocked ups here for testing serialize and deserializing objects

<a name='M-JsonCodeSamples-Models-Mockups-ShippingInfoList'></a>
### ShippingInfoList() `method`

##### Summary

Mocked list of [ShippingInfo](#T-JsonCodeSamples-Models-ShippingInfo 'JsonCodeSamples.Models.ShippingInfo')

##### Returns

[List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1')

##### Parameters

This method has no parameters.

<a name='M-JsonCodeSamples-Models-Mockups-ShippingInfoNestedList'></a>
### ShippingInfoNestedList() `method`

##### Summary

Mocked list of [ShippingInfo](#T-JsonCodeSamples-Models-ShippingInfo 'JsonCodeSamples.Models.ShippingInfo') with nested properties

##### Returns

Mocked list of <see cref="ShippingInfo"/>

##### Parameters

This method has no parameters.

<a name='M-JsonCodeSamples-Models-Mockups-singleShipInfo'></a>
### singleShipInfo() `method`

##### Summary

Single [ShippingInfo](#T-JsonCodeSamples-Models-ShippingInfo 'JsonCodeSamples.Models.ShippingInfo') mockup

##### Returns

[ShippingInfo](#T-JsonCodeSamples-Models-ShippingInfo 'JsonCodeSamples.Models.ShippingInfo')

##### Parameters

This method has no parameters.

<a name='T-JsonCodeSamples-Classes-NewtonSettings'></a>
## NewtonSettings `type`

##### Namespace

JsonCodeSamples.Classes

##### Summary

Setting for serializing with Json.net

<a name='M-JsonCodeSamples-Classes-NewtonSettings-SettingsDefault'></a>
### SettingsDefault() `method`

##### Summary

Format indent

##### Returns



##### Parameters

This method has no parameters.

<a name='M-JsonCodeSamples-Classes-NewtonSettings-SettingsIgnoreReferenceLooping'></a>
### SettingsIgnoreReferenceLooping() `method`

##### Summary

Format indent
Prevent Self referencing loop detected

##### Parameters

This method has no parameters.

<a name='T-JsonCodeSamples-Models-Person'></a>
## Person `type`

##### Namespace

JsonCodeSamples.Models

##### Summary

Sample class

<a name='P-JsonCodeSamples-Models-Person-firstname'></a>
### firstname `property`

##### Summary

First name

<a name='P-JsonCodeSamples-Models-Person-gender'></a>
### gender `property`

##### Summary

Gender

<a name='P-JsonCodeSamples-Models-Person-lastname'></a>
### lastname `property`

##### Summary

Last name

<a name='T-JsonCodeSamples-Program'></a>
## Program `type`

##### Namespace

JsonCodeSamples

<a name='M-JsonCodeSamples-Program-Main'></a>
### Main() `method`

##### Summary

The main entry point for the application.

##### Parameters

This method has no parameters.

<a name='T-JsonCodeSamples-Properties-Resources'></a>
## Resources `type`

##### Namespace

JsonCodeSamples.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-JsonCodeSamples-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-JsonCodeSamples-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-JsonCodeSamples-Models-ShippingInfo'></a>
## ShippingInfo `type`

##### Namespace

JsonCodeSamples.Models

##### Summary

Example cass

<a name='M-JsonCodeSamples-Models-ShippingInfo-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor

##### Parameters

This constructor has no parameters.

<a name='P-JsonCodeSamples-Models-ShippingInfo-AddressDetails'></a>
### AddressDetails `property`

##### Summary

Address details

<a name='P-JsonCodeSamples-Models-ShippingInfo-Id'></a>
### Id `property`

##### Summary

Primary key

<a name='P-JsonCodeSamples-Models-ShippingInfo-SomethingNested'></a>
### SomethingNested `property`

##### Summary

For demoing nested properties

<a name='M-JsonCodeSamples-Models-ShippingInfo-ToString'></a>
### ToString() `method`

##### Summary

For debugging

##### Returns



##### Parameters

This method has no parameters.

<a name='T-JsonCodeSamples-Models-SomethingNested'></a>
## SomethingNested `type`

##### Namespace

JsonCodeSamples.Models

##### Summary

Sample class for [Person](#T-JsonCodeSamples-Models-Person 'JsonCodeSamples.Models.Person')

<a name='P-JsonCodeSamples-Models-SomethingNested-Id'></a>
### Id `property`

##### Summary

Primary key

<a name='P-JsonCodeSamples-Models-SomethingNested-Value'></a>
### Value `property`

##### Summary

Dummy value

![img](../assets/kpmvp1.png)