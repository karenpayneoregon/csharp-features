# About

Various code sample for C# 8 Range type

# Data

Data was read from [this table](https://gist.github.com/karenpayneoregon/9bdf1a7d5310ac1d562b2326d79d6038) using the following to generate json data.
```sql
SELECT ContactId, 
       FirstName, 
       LastName
FROM NorthWind2020.dbo.Contacts FOR JSON AUTO;
```