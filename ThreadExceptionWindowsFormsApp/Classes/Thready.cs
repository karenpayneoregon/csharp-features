using System;
using System.Threading;

namespace ThreadExceptionWindowsFormsApp.Classes
{
    /// <summary>
    /// For intentional runtime exception
    /// </summary>
    public class Thready
    {
        public static Thread TheThread { get; private set; }

        public static void Start()
        {
            var threadStart = new ThreadStart(Execute);
            TheThread = new Thread(threadStart);
            TheThread.Start();
        }
        
        public static void Execute() => throw new Exception("The method or operation is not implemented.");
    }
}