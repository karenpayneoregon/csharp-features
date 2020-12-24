using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Switches.Models;

namespace Switches.Classes
{
    public class PersonGrades : PersonEntity
    {
        public decimal? Grade { get; set; }
        public string GradeLetter { get; set; }
    }
}
