<a name='assembly'></a>
# ConsoleReadLineTimeOut1

## Contents

- [ConsoleHelpers](#T-ConsoleReadLineTimeOut1-ConsoleHelpers 'ConsoleReadLineTimeOut1.ConsoleHelpers')
  - [ReadLineAsDate()](#M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineAsDate 'ConsoleReadLineTimeOut1.ConsoleHelpers.ReadLineAsDate')
  - [ReadLineAsDateTimeout()](#M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineAsDateTimeout-System-Nullable{System-TimeSpan}- 'ConsoleReadLineTimeOut1.ConsoleHelpers.ReadLineAsDateTimeout(System.Nullable{System.TimeSpan})')
  - [ReadLineAsDoubleTimeout()](#M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineAsDoubleTimeout-System-Nullable{System-TimeSpan}- 'ConsoleReadLineTimeOut1.ConsoleHelpers.ReadLineAsDoubleTimeout(System.Nullable{System.TimeSpan})')
  - [ReadLineAsInt()](#M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineAsInt 'ConsoleReadLineTimeOut1.ConsoleHelpers.ReadLineAsInt')
  - [ReadLineAsIntTimeout()](#M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineAsIntTimeout-System-Nullable{System-TimeSpan}- 'ConsoleReadLineTimeOut1.ConsoleHelpers.ReadLineAsIntTimeout(System.Nullable{System.TimeSpan})')
  - [ReadLineAsString()](#M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineAsString 'ConsoleReadLineTimeOut1.ConsoleHelpers.ReadLineAsString')
  - [ReadLineAsStringTimeout(timeout)](#M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineAsStringTimeout-System-Nullable{System-TimeSpan}- 'ConsoleReadLineTimeOut1.ConsoleHelpers.ReadLineAsStringTimeout(System.Nullable{System.TimeSpan})')
  - [ReadLineDateTimeWaitTenSeconds()](#M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineDateTimeWaitTenSeconds 'ConsoleReadLineTimeOut1.ConsoleHelpers.ReadLineDateTimeWaitTenSeconds')
  - [ReadLineIntTimeWait()](#M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineIntTimeWait 'ConsoleReadLineTimeOut1.ConsoleHelpers.ReadLineIntTimeWait')
  - [ReadLineWaitFiveSeconds()](#M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineWaitFiveSeconds 'ConsoleReadLineTimeOut1.ConsoleHelpers.ReadLineWaitFiveSeconds')
  - [ReadLineWaitOneMinutes()](#M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineWaitOneMinutes 'ConsoleReadLineTimeOut1.ConsoleHelpers.ReadLineWaitOneMinutes')
  - [ReadLineWaitTenSeconds()](#M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineWaitTenSeconds 'ConsoleReadLineTimeOut1.ConsoleHelpers.ReadLineWaitTenSeconds')
  - [ReadLineWaitThirtySeconds()](#M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineWaitThirtySeconds 'ConsoleReadLineTimeOut1.ConsoleHelpers.ReadLineWaitThirtySeconds')
  - [ToYesNoString(value)](#M-ConsoleReadLineTimeOut1-ConsoleHelpers-ToYesNoString-System-Boolean- 'ConsoleReadLineTimeOut1.ConsoleHelpers.ToYesNoString(System.Boolean)')

<a name='T-ConsoleReadLineTimeOut1-ConsoleHelpers'></a>
## ConsoleHelpers `type`

##### Namespace

ConsoleReadLineTimeOut1

<a name='M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineAsDate'></a>
### ReadLineAsDate() `method`

##### Summary

Read line, convert to DateTime

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineAsDateTimeout-System-Nullable{System-TimeSpan}-'></a>
### ReadLineAsDateTimeout() `method`

##### Summary

Read line and convert to [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') with timeout

##### Returns

[DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime')

##### Parameters

This method has no parameters.

<a name='M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineAsDoubleTimeout-System-Nullable{System-TimeSpan}-'></a>
### ReadLineAsDoubleTimeout() `method`

##### Summary

Read line and convert to [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') with timeout

##### Returns

[TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan')

##### Parameters

This method has no parameters.

<a name='M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineAsInt'></a>
### ReadLineAsInt() `method`

##### Summary

Read line and convert to int

##### Returns

[Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32')

##### Parameters

This method has no parameters.

<a name='M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineAsIntTimeout-System-Nullable{System-TimeSpan}-'></a>
### ReadLineAsIntTimeout() `method`

##### Summary

Read line and convert to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') with timeout

##### Returns

[Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32')

##### Parameters

This method has no parameters.

<a name='M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineAsString'></a>
### ReadLineAsString() `method`

##### Summary

Verbose method name for reading a string

##### Returns

[DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime')

##### Parameters

This method has no parameters.

<a name='M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineAsStringTimeout-System-Nullable{System-TimeSpan}-'></a>
### ReadLineAsStringTimeout(timeout) `method`

##### Summary

Wait a specific amount of time for Console.ReadLine. Must press ENTER to collect input or no key to timeout

##### Returns

Input from ReadLine or an empty string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| timeout | [System.Nullable{System.TimeSpan}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.TimeSpan}') | Valid time span or if not passed default to [DefaultTimeOut](#P-ConsoleReadLineTimeOut1-ConsoleHelpers-DefaultTimeOut 'ConsoleReadLineTimeOut1.ConsoleHelpers.DefaultTimeOut') in seconds |

<a name='M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineDateTimeWaitTenSeconds'></a>
### ReadLineDateTimeWaitTenSeconds() `method`

##### Summary

Read line and convert to [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') with one minute timeout

##### Returns

[DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime')

##### Parameters

This method has no parameters.

<a name='M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineIntTimeWait'></a>
### ReadLineIntTimeWait() `method`

##### Summary

Read line and convert to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') with one minute timeout

##### Returns

[Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32')

##### Parameters

This method has no parameters.

<a name='M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineWaitFiveSeconds'></a>
### ReadLineWaitFiveSeconds() `method`

##### Summary

Read line and convert to [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with five seconds timeout

##### Returns

[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineWaitOneMinutes'></a>
### ReadLineWaitOneMinutes() `method`

##### Summary

Read line and convert to [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with thirty seconds timeout

##### Returns

[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineWaitTenSeconds'></a>
### ReadLineWaitTenSeconds() `method`

##### Summary

Read line and convert to [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with ten seconds timeout

##### Returns

[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-ConsoleReadLineTimeOut1-ConsoleHelpers-ReadLineWaitThirtySeconds'></a>
### ReadLineWaitThirtySeconds() `method`

##### Summary

Read line and convert to [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with thirty seconds timeout

##### Returns

[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-ConsoleReadLineTimeOut1-ConsoleHelpers-ToYesNoString-System-Boolean-'></a>
### ToYesNoString(value) `method`

##### Summary

Convert bool to Yes, No

##### Returns

Yes or No

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |
