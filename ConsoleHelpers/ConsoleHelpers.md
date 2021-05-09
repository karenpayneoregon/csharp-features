<a name='assembly'></a>
# ConsoleHelpers

## Contents

- [ConsoleColors](#T-ConsoleHelpers-ConsoleColors 'ConsoleHelpers.ConsoleColors')
  - [EmptyLine()](#M-ConsoleHelpers-ConsoleColors-EmptyLine 'ConsoleHelpers.ConsoleColors.EmptyLine')
  - [WriteHeader(message)](#M-ConsoleHelpers-ConsoleColors-WriteHeader-System-String- 'ConsoleHelpers.ConsoleColors.WriteHeader(System.String)')
  - [WriteIndented(message)](#M-ConsoleHelpers-ConsoleColors-WriteIndented-System-String- 'ConsoleHelpers.ConsoleColors.WriteIndented(System.String)')
  - [WriteIndented(message)](#M-ConsoleHelpers-ConsoleColors-WriteIndented-System-Int32- 'ConsoleHelpers.ConsoleColors.WriteIndented(System.Int32)')
  - [WriteIndented(message)](#M-ConsoleHelpers-ConsoleColors-WriteIndented-System-Boolean- 'ConsoleHelpers.ConsoleColors.WriteIndented(System.Boolean)')
  - [WriteSectionBold(message,line)](#M-ConsoleHelpers-ConsoleColors-WriteSectionBold-System-String,System-Boolean- 'ConsoleHelpers.ConsoleColors.WriteSectionBold(System.String,System.Boolean)')
  - [WriteSectionBoldIndented(message,line)](#M-ConsoleHelpers-ConsoleColors-WriteSectionBoldIndented-System-String,System-Boolean- 'ConsoleHelpers.ConsoleColors.WriteSectionBoldIndented(System.String,System.Boolean)')
  - [WriteSectionYellow(message,line)](#M-ConsoleHelpers-ConsoleColors-WriteSectionYellow-System-String,System-Boolean- 'ConsoleHelpers.ConsoleColors.WriteSectionYellow(System.String,System.Boolean)')
- [ConsoleKeysHelper](#T-ConsoleHelpers-ConsoleKeysHelper 'ConsoleHelpers.ConsoleKeysHelper')
  - [PauseFiveSeconds(message)](#M-ConsoleHelpers-ConsoleKeysHelper-PauseFiveSeconds-System-String- 'ConsoleHelpers.ConsoleKeysHelper.PauseFiveSeconds(System.String)')
  - [PauseTenSeconds(message)](#M-ConsoleHelpers-ConsoleKeysHelper-PauseTenSeconds-System-String- 'ConsoleHelpers.ConsoleKeysHelper.PauseTenSeconds(System.String)')
  - [ReadLineFiveSeconds(message)](#M-ConsoleHelpers-ConsoleKeysHelper-ReadLineFiveSeconds-System-String- 'ConsoleHelpers.ConsoleKeysHelper.ReadLineFiveSeconds(System.String)')
  - [ReadLineTenSeconds(message)](#M-ConsoleHelpers-ConsoleKeysHelper-ReadLineTenSeconds-System-String- 'ConsoleHelpers.ConsoleKeysHelper.ReadLineTenSeconds(System.String)')
  - [ReadLineWithTimeout(seconds,message)](#M-ConsoleHelpers-ConsoleKeysHelper-ReadLineWithTimeout-System-Int32,System-String- 'ConsoleHelpers.ConsoleKeysHelper.ReadLineWithTimeout(System.Int32,System.String)')
  - [ReadLineWithTimeSpanTimeout(timeout,message)](#M-ConsoleHelpers-ConsoleKeysHelper-ReadLineWithTimeSpanTimeout-System-Nullable{System-TimeSpan},System-String- 'ConsoleHelpers.ConsoleKeysHelper.ReadLineWithTimeSpanTimeout(System.Nullable{System.TimeSpan},System.String)')
  - [WaitReadLine(message)](#M-ConsoleHelpers-ConsoleKeysHelper-WaitReadLine-System-String- 'ConsoleHelpers.ConsoleKeysHelper.WaitReadLine(System.String)')
- [ConsoleRectangle](#T-ConsoleHelpers-ConsoleRectangle 'ConsoleHelpers.ConsoleRectangle')
  - [#ctor(width,height,location,borderColor,text)](#M-ConsoleHelpers-ConsoleRectangle-#ctor-System-Int32,System-Int32,System-Drawing-Point,System-ConsoleColor,System-String- 'ConsoleHelpers.ConsoleRectangle.#ctor(System.Int32,System.Int32,System.Drawing.Point,System.ConsoleColor,System.String)')
  - [BorderColor](#P-ConsoleHelpers-ConsoleRectangle-BorderColor 'ConsoleHelpers.ConsoleRectangle.BorderColor')
  - [Height](#P-ConsoleHelpers-ConsoleRectangle-Height 'ConsoleHelpers.ConsoleRectangle.Height')
  - [Location](#P-ConsoleHelpers-ConsoleRectangle-Location 'ConsoleHelpers.ConsoleRectangle.Location')
  - [Width](#P-ConsoleHelpers-ConsoleRectangle-Width 'ConsoleHelpers.ConsoleRectangle.Width')
  - [Draw()](#M-ConsoleHelpers-ConsoleRectangle-Draw 'ConsoleHelpers.ConsoleRectangle.Draw')

<a name='T-ConsoleHelpers-ConsoleColors'></a>
## ConsoleColors `type`

##### Namespace

ConsoleHelpers

##### Summary

Methods to write in color

<a name='M-ConsoleHelpers-ConsoleColors-EmptyLine'></a>
### EmptyLine() `method`

##### Summary

Write an empty line

##### Parameters

This method has no parameters.

<a name='M-ConsoleHelpers-ConsoleColors-WriteHeader-System-String-'></a>
### WriteHeader(message) `method`

##### Summary

Write text in Rectangle

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message to display |

<a name='M-ConsoleHelpers-ConsoleColors-WriteIndented-System-String-'></a>
### WriteIndented(message) `method`

##### Summary

Write message indented

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to display |

<a name='M-ConsoleHelpers-ConsoleColors-WriteIndented-System-Int32-'></a>
### WriteIndented(message) `method`

##### Summary

Write int indented line no line

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | int value |

<a name='M-ConsoleHelpers-ConsoleColors-WriteIndented-System-Boolean-'></a>
### WriteIndented(message) `method`

##### Summary

Write bool indented

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | bool value |

<a name='M-ConsoleHelpers-ConsoleColors-WriteSectionBold-System-String,System-Boolean-'></a>
### WriteSectionBold(message,line) `method`

##### Summary

Write message in White foreground

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to display |
| line | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Add underline |

<a name='M-ConsoleHelpers-ConsoleColors-WriteSectionBoldIndented-System-String,System-Boolean-'></a>
### WriteSectionBoldIndented(message,line) `method`

##### Summary

Write message in White foreground indented

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to display |
| line | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Add underline |

<a name='M-ConsoleHelpers-ConsoleColors-WriteSectionYellow-System-String,System-Boolean-'></a>
### WriteSectionYellow(message,line) `method`

##### Summary

Write message in yellow foreground

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to display |
| line | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Add underline |

<a name='T-ConsoleHelpers-ConsoleKeysHelper'></a>
## ConsoleKeysHelper `type`

##### Namespace

ConsoleHelpers

##### Summary

Methods to work with keyboard

<a name='M-ConsoleHelpers-ConsoleKeysHelper-PauseFiveSeconds-System-String-'></a>
### PauseFiveSeconds(message) `method`

##### Summary

Wrapper for to wait five seconds

##### Returns

user input or empty string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message to display (optional) |

<a name='M-ConsoleHelpers-ConsoleKeysHelper-PauseTenSeconds-System-String-'></a>
### PauseTenSeconds(message) `method`

##### Summary

Wrapper for to wait ten seconds

##### Returns

user input or empty string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message to display (optional) |

<a name='M-ConsoleHelpers-ConsoleKeysHelper-ReadLineFiveSeconds-System-String-'></a>
### ReadLineFiveSeconds(message) `method`

##### Summary

Wrapper for to wait five seconds

##### Returns

user input or empty string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message to display (optional) |

<a name='M-ConsoleHelpers-ConsoleKeysHelper-ReadLineTenSeconds-System-String-'></a>
### ReadLineTenSeconds(message) `method`

##### Summary

Wrapper for to wait ten seconds

##### Returns

user input or empty string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message to display (optional) |

<a name='M-ConsoleHelpers-ConsoleKeysHelper-ReadLineWithTimeout-System-Int32,System-String-'></a>
### ReadLineWithTimeout(seconds,message) `method`

##### Summary

Read line with timeout and optional message

##### Returns

Empty string when nothing entered and enter key pressed or text entered and enter key pressed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| seconds | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Seconds to wait |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message to display (optional) |

<a name='M-ConsoleHelpers-ConsoleKeysHelper-ReadLineWithTimeSpanTimeout-System-Nullable{System-TimeSpan},System-String-'></a>
### ReadLineWithTimeSpanTimeout(timeout,message) `method`

##### Summary

Provides an enhanced Console.ReadLine with a time out.

##### Returns

Input from a Task or if no input an empty string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| timeout | [System.Nullable{System.TimeSpan}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.TimeSpan}') | Timeout |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional text to display |

##### Remarks

Example, wait for two seconds and a half
ConsoleReadLineWithTimeout(TimeSpan.FromSeconds(2.5))

Example, use default, wait for one second
ConsoleReadLineWithTimeout(TimeSpan.FromSeconds())

<a name='M-ConsoleHelpers-ConsoleKeysHelper-WaitReadLine-System-String-'></a>
### WaitReadLine(message) `method`

##### Summary

Write line for user to press a key with default text

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-ConsoleHelpers-ConsoleRectangle'></a>
## ConsoleRectangle `type`

##### Namespace

ConsoleHelpers

##### Summary

Helper to create colored boxes

<a name='M-ConsoleHelpers-ConsoleRectangle-#ctor-System-Int32,System-Int32,System-Drawing-Point,System-ConsoleColor,System-String-'></a>
### #ctor(width,height,location,borderColor,text) `constructor`

##### Summary

Create Rectangle with border color color

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| width | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | width of Rectangle |
| height | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | height of Rectangle |
| location | [System.Drawing.Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') | location of Rectangle |
| borderColor | [System.ConsoleColor](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ConsoleColor 'System.ConsoleColor') | Rectangle border color |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to display |

<a name='P-ConsoleHelpers-ConsoleRectangle-BorderColor'></a>
### BorderColor `property`

##### Summary

Border color

<a name='P-ConsoleHelpers-ConsoleRectangle-Height'></a>
### Height `property`

##### Summary

Height

<a name='P-ConsoleHelpers-ConsoleRectangle-Location'></a>
### Location `property`

##### Summary

Location

<a name='P-ConsoleHelpers-ConsoleRectangle-Width'></a>
### Width `property`

##### Summary

Width

<a name='M-ConsoleHelpers-ConsoleRectangle-Draw'></a>
### Draw() `method`

##### Summary

Draw box

##### Parameters

This method has no parameters.
