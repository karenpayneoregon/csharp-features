using Switches.Models;

namespace Switches.Classes
{
    public class PersonGrades : PersonEntity
    {
        public decimal? Grade { get; set; }
        public string GradeLetter { get; set; }
    }
}
