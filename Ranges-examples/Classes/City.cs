using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranges_examples.Classes
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Index StartIndex { get; set; }
        public Index EndIndex { get; set; }
        public override string ToString() => $"{Name,25} {StartIndex, 3} {EndIndex,4}";

    }
}
