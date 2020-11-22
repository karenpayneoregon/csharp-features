using System.Collections.Generic;
using RecursivePatterns.Classes;

namespace NewExpressions.Classes
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
}