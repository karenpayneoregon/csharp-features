using System;
using System.Diagnostics;

namespace TraceMessagesConsole
{
    class Program
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.trace?view=net-5.0
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Trace.WriteLine("Some Trace messages to follow:");
            Trace.IndentSize = 5;
            Trace.Indent();
            Trace.TraceInformation("This is Trace information.");
            Trace.Indent();
            Trace.TraceInformation("This is Trace information - indented.");
            Trace.Unindent();
            Trace.TraceWarning("This is Trace Warning.");
            Trace.TraceError("This is Trace Error.");
            Trace.Unindent();
            Trace.Flush();
            //
            Debug.WriteLine("This is Debug Line.");

            Console.WriteLine("See Output window");
            Console.ReadLine();
        }
    }
}
