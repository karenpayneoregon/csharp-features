using System.Collections.Generic;

namespace NewExpressions.Classes
{
    public class Manager : Person
    {
        public int YearsAsManager { get; set; }
        public List<Employee> Employees { get; set; }
    }
}