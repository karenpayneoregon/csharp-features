# About

This project demonstrates using the [new operator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/new-operator) to create a list of Person.

```csharp
using System;
using System.Collections.Generic;
using NewExpressions.Classes;

namespace NewExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new();

            foreach (var person in Mocked.PeopleList())
            {
                people.Add(person);
            }

            Console.WriteLine("People:");

            foreach (var person in people)
            {
                ConsoleWriter.WriteConsoleColorNewLine(
                    new ColoredString(ConsoleColor.White, $"{person.Id} "), 
                    new ColoredString(ConsoleColor.Yellow, $"{person.FullName}"));
                
            }

            Console.ReadLine();
        }
    }
}

```