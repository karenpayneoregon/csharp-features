using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using ExceptionHandling;

namespace RecursivePatterns.Classes
{
    /// <summary>
    /// C#9
    /// </summary>
    public static class LanguageExtensions
    {
        public static List<Employee> GetEmployeesWhereManagerHasYearsAsManager(this Person person) => person switch
        {
            Manager { YearsAsManager: >=4 } manager => manager.Employees,
            Manager { YearsAsManager: 3 } manager => manager.Employees,
            _ => null
        };
    }

    public static class Example
    {
        public static bool Demo(int item, string folder) => item switch
        {
            1 => Operations.DoSomething1(folder),
            2 => Operations.DoSomething2(folder),
            _ => Operations.DefaultSwitch()
        };
    }
    public class Validates
    {
        public static bool ValidateBirthYear(string birthYear) =>
            birthYear.Length == 4 && birthYear.All(char.IsDigit)
                                  && int.TryParse(birthYear, out var year)
                                  && year is >= 1920 and <= 2002;
    }

    public class Operations
    {
        public static void WriteConventional(Exception exception, ExceptionLogType exceptionLogType = ExceptionLogType.General)
        {
            var fileName = "";

            switch (exceptionLogType)
            {
                case ExceptionLogType.Post:
                    fileName = "PostUnhandledException.txt";
                    break;
                case ExceptionLogType.General:
                    fileName = "GeneralUnhandledException.txt";
                    break;
                case ExceptionLogType.Data:
                    fileName = "DataUnhandledException.txt";
                    break;
                case ExceptionLogType.Unknown:
                    fileName = "UnknownUnhandledException.txt";
                    break;
                default: throw new NotImplementedException();
            }


            Debug.WriteLine($"Conventional: {fileName}");

        }
        public static void WriteByExpression(Exception exception, ExceptionLogType exceptionLogType = ExceptionLogType.General)
        {
            var fileName = exceptionLogType switch
            {
                ExceptionLogType.General => "GeneralUnhandledException.txt",
                ExceptionLogType.Data => "DataUnhandledException.txt",
                ExceptionLogType.Unknown => "UnknownUnhandledException.txt",
                ExceptionLogType.Post => "PostUnhandledException.txt",
                _ => throw new NotImplementedException()
            };

            Debug.WriteLine($"C# 8: {fileName}");

        }
        
        public static bool DoSomething1(string folder)
        {
            if (Directory.Exists(folder))
            {
                return true;
            }
            else
            {
                Directory.CreateDirectory(folder);
                return false;
            }
        }
        public static bool DoSomething2(string folder) => /* do whatever*/ true;

        public static bool DefaultSwitch() => false;
    }
}