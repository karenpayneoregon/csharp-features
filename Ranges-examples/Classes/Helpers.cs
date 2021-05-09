using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranges_examples.Classes
{
    public class Helpers
    {
        /// <summary>
        /// Get elements between two elements 
        /// </summary>
        /// <param name="sender">string array</param>
        /// <param name="startItem">start element</param>
        /// <param name="endItem">end element</param>
        /// <returns>Range between start and end items or null</returns>
        public static string[] GetBetweenInclusive(string[] sender, [DisallowNull] string startItem, [DisallowNull] string endItem)
        {
            /*
             * Note this statement uses an anonymous type as there is no need to expose this outside of the current method
             */
            var elementsList = sender.Select((element, index) => new 
            {
                Name = element, 
                StartIndex = new Index(index), 
                EndIndex = new Index(Enumerable.Range(0, sender.Length).Reverse().ToList()[index], true)
            }).ToList();

            var start = elementsList.FirstOrDefault(item => item.Name == startItem);
            var end = elementsList.FirstOrDefault(item => item.Name == endItem);

            return start is null || end is null ? null : sender[start.StartIndex..end.EndIndex];
        }
    }
}
