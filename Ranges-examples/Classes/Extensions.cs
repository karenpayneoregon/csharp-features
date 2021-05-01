using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranges_examples.Classes
{
    public static class Extensions
    {
        public static (Index startIndex, Index endIndex) Between(this List<City> sender, string firstCity, string lastCity)
        {
            return (sender.FirstOrDefault(x => x.Name == firstCity).StartIndex, sender.FirstOrDefault(x => x.Name == lastCity).EndIndex);
        }
    }
}
