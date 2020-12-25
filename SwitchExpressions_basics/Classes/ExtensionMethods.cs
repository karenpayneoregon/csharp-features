using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExpressions_basics.Classes
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Provides a IN like condition generic method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sender"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static bool InCondition<T>(this T sender, params T[] values) => values.Contains(sender);
    }
}
