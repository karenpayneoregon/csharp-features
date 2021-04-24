using System.Collections.Generic;
using System.Threading.Tasks;

namespace YieldIAsyncEnumerable.Classes
{
    public class Helper
    {
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