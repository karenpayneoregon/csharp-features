using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranges_examples.Classes
{
    public class City
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of city
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Start <see cref="Index"/>
        /// </summary>
        public Index StartIndex { get; set; }
        /// <summary>
        /// End <see cref="Index"/>
        /// </summary>
        public Index EndIndex { get; set; }
        /// <summary>
        /// Visual for inspection
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{Name,25} {StartIndex, 3} {EndIndex,4}";

    }
}
