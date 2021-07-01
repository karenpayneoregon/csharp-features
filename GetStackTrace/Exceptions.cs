using System;
using System.IO;
using static System.IO.File;

namespace GetStackTrace
{
    /// <summary>
    /// Provides writing run time exceptions to a text file
    /// </summary>
    public static class Exceptions
    {
        /// <summary>
        /// Write Exception information to UnhandledException.txt in the executable folder.
        /// </summary>
        /// <param name="exception">Strong typed <seealso cref="Exception"/></param>
        public static void Write(this Exception exception)
        {
            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UnhandledException.txt");
            
            try
            {
                var current = exception.ToLogString(Environment.StackTrace);
                AppendAllText(fileName, current);
            }
            catch
            {
                // ignored - something went really bad
            }
        }
    }
}