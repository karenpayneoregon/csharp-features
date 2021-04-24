using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace YieldIAsyncEnumerable.Classes
{
    public static class Experimenting
    {
        public static async IAsyncEnumerable<int> RangeAsync(this int start, int count, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {

            for (int index = 0; index < count; index++)
            {
                if (cancellationToken.IsCancellationRequested) cancellationToken.ThrowIfCancellationRequested();
                await Task.Delay(GlobalStuff.TimeSpan, cancellationToken);
                yield return start + index;
            }
        }
        public static void InvokeIfRequired<T>(this T control, Action<T> action) where T : ISynchronizeInvoke
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => action(control)), null);
            }
            else
            {
                action(control);
            }
        }
    }
}