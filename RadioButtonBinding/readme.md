# About

Demonstrates data binding properties of a class to grouped RadioButton controls.

## Requires to run sample code

- .NET Framework 4.8
- Core 3.1

## Notes

- Will work with .NET Framework 4.7 and higher and need not be Core project as this code was originally done in VS2017 while the sample code has been ported to Core. 
- With .NET Core 5 there is no BindingNavigator which is why the code was not in .NET Core 3.1
- Data is read from a comma-delimited file and will work with data from other sources like a database using conventional data access, Entity Framework 6 or Entity Framework Core.
- Save all button writes current data back to the original data source.
- Inspect list button provides a peek at current people in the list.

![screen](../assets/GroupedRadioButtons.png)