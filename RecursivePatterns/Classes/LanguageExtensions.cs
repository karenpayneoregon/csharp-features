using System.Collections.Generic;
using System.IO;

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

    public class Operations
    {
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