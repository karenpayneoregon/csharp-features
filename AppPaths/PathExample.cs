using System;
using System.Diagnostics;
using System.IO;

namespace AppPaths
{
    public static class PathExample
    {
        public static void Show()
        {
            Console.WriteLine($"      Launched from {Environment.CurrentDirectory}");
            Console.WriteLine($"  Physical location {AppDomain.CurrentDomain.BaseDirectory}");
            Console.WriteLine($" AppContext.BaseDir {AppContext.BaseDirectory}");
            Console.WriteLine($"       Runtime Call {Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName)}");
        }
    }
}
