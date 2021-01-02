using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExceptionHandling;
using ExceptionHandling.Interfaces;

namespace ThreadExceptionWindowsFormsApp.Helpers
{
    /// <summary>
    /// Provides events to deal with unhandled runtime exceptions
    /// </summary>
    public static class UnhandledExceptions
    {
        
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

            var f = new AppErrorForm { Text = @"Thread Exception" };
            f.ShowDialog();
            Application.Exit();

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

            var f = new AppErrorForm { Text = @"Unhandled Exception" };
            f.ShowDialog();
            Application.Exit();

        }
    }
}
