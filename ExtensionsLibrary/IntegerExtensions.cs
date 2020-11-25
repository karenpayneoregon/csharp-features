using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsLibrary
{
    public static class IntegerExtensions
    {
        /// <summary>
        /// Flip negative to positive or positive to negative
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static int Invert(this int source) =>
            source * (-1);

        /// <summary>
        /// Flip negative to positive or positive to negative alternative via bitwise operation
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static int InvertBitwise(this int source) =>
            ~source + 1;
    }
}
