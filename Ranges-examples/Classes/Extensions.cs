using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranges_examples.Classes
{
    public static class Extensions
    {
        /// <summary>
        /// Get Indices for between two city names. Since city names are static there is no assertion on if a city exists.
        /// </summary>
        /// <param name="sender">List of <seealso cref="City"/></param>
        /// <param name="firstCity">First city name</param>
        /// <param name="lastCity">Last city name</param>
        /// <returns>Start city index, last city index with ^ (hat)</returns>
        /// <remarks>
        /// To keep code short null checks are excluded
        /// </remarks>
        public static (Index startIndex, Index endIndex) Between(this List<City> sender, string firstCity, string lastCity)
        {
            return (sender.FirstOrDefault(name => name.Name == firstCity).StartIndex, sender.FirstOrDefault(x => x.Name == lastCity).EndIndex);
        }
    }
}
