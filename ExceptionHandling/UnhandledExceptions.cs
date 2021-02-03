using System;
using System.Threading;
using ExceptionHandling.Classes;
using ExceptionHandling.Interfaces;
using ExceptionHandling.LogClasses; //using System.Windows.Forms;

namespace ExceptionHandling
{
    /// <summary>
    /// Provides events to deal with unhandled runtime exceptions
    /// </summary>
    public static class UnhandledExceptions
    {
        public delegate void OnProcessingCompleted();
        public static event OnProcessingCompleted OnProcessingCompletedEvent;
        
        private static readonly LogManager LogManager = new();
        
        public static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                LogManager.Log(LogLevel.Critical, e.Exception.ToLogString(Environment.StackTrace));
            }
            catch (Exception)
            {
                // ignored - do not take chances of causing another exception
            }

            OnProcessingCompletedEvent?.Invoke();
            
        }
        public static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {

            try
            {
                LogManager.Log(LogLevel.Critical, (e.ExceptionObject as Exception).ToLogString(Environment.StackTrace));
            }
            catch (Exception)
            {
                // ignored - do not take chances of causing another exception
            }

            OnProcessingCompletedEvent?.Invoke();
            
        }
    }
}
