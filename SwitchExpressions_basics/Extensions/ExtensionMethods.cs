using System.Linq;

namespace SwitchExpressions_basics.Extensions
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
