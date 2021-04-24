using System.Collections.Generic;
using System.Threading.Tasks;

namespace YieldIAsyncEnumerable.Classes
{
    public class Helpers
    {
        /// <summary>
        /// Extension method based off Microsoft's code sample from a blog which I don't remember the address
        /// </summary>
        /// <param name="divider"></param>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        public static async IAsyncEnumerable<int> RangeAsync(int divider, int maxNumber)
        {
            for (var index = 0; index < maxNumber; index++)
            {
                if (index % divider == 0)
                {
                    await Task.Delay(GlobalStuff.TimeSpan);
                    yield return index;
                }
            }
        }
    }
}