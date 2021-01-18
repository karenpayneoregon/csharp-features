using System;
using System.Text.RegularExpressions;

namespace ClearControlsWindowsForms.Extensions
{
    public static class ControlHelpers
    {
        public static int GetInt(this string sender) => Convert.ToInt32(Regex.Match(sender, @"\d+\.*\d*").Value) - 1;
    }
}
