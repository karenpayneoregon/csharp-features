using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranges_examples.Classes
{
    class BasicRangeIndices
    {
        public static void Examples()
        {
            int[] numberIntegers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //Index index1 = 3;  // number 3 from beginning (zero-based)
            //Index index2 = ^4; // number 4 from end ("hat" operator)

            //Debug.WriteLine($"{numberIntegers[index1]}, {numberIntegers[index2]}"); // "3, 6"

            
            //foreach (var index in numberIntegers[2..5]) // start index is inclusive, end index is exclusive (non-inclusive)!
            //{
            //    Debug.Write(index); // 234
            //}
            
            Debug.WriteLine("");


            //foreach (var index in numberIntegers[8..^1]) // start index is inclusive, end index is exclusive (non-inclusive)!
            //{
            //    Debug.Write(index); // 8
            //}
            
            //Debug.WriteLine("");


            //foreach (var index in numberIntegers[3..]) // start/end index only
            //{
            //    Debug.Write(index); // 3456789
            //}

            //Debug.WriteLine("");


            //foreach (var index in numberIntegers[..]) // all
            //{
            //    Debug.Write(index); // 0123456789
            //}
            //Debug.WriteLine("");

            var test = numberIntegers[1..^5];


            foreach (var numberInteger in numberIntegers[1..^5])
            {
                Console.WriteLine(numberInteger);
            }

            Debug.WriteLine("");
        }
    }
}
