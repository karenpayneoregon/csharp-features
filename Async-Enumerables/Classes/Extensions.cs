using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Async_Enumerables.Classes
{
    public static class Extensions
    {
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
