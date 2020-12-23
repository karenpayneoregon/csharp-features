using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Enumerables.Classes
{
    public class Helpers
    {
        public delegate void OnIterate(int sender);
        /// <summary>
        /// Provides current iteration value
        /// </summary>
        public static event OnIterate OnIterateEvent;

        public static async IAsyncEnumerable<int> RangeAsync(int start, int count, int delay, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for (var index = 0; index < count; index++)
            {
                await Task.Delay(delay, cancellationToken);
                yield return start + index;
            }
        }
        /// <summary>
        /// Run basic example with option to cancel
        /// </summary>
        /// <param name="token">Valid CancellationToken</param>
        /// <returns></returns>
        public static async Task RunBasicExample(CancellationToken token)
        {
            await foreach (var item in RangeAsync(1, 3000, 100, token))
            {
                if (token.IsCancellationRequested)
                {
                    token.ThrowIfCancellationRequested();
                }

                if (item > 100)
                {
                    throw new Exception("Well now");
                }
                OnIterateEvent?.Invoke(item);
            }
        }
    }
}
