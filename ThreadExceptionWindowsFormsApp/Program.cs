using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExceptionHandling;
using ExceptionHandling.Interfaces;

namespace ThreadExceptionWindowsFormsApp
{
    /// <summary>
    /// Rig for unhandled exceptions.
    /// Note Text property set on error form is for demo purposes only
    /// </summary>
    static class Program
    {
        //private static readonly string ExceptionFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UnhandledException.txt");

        private static readonly LogManager LogManager = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Handling UI thread exceptions to the event.
            Application.ThreadException += Application_ThreadException;

            // For handling non-UI thread exceptions to the event. 
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            
            Application.Run(new Form1());
        }
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                LogManager.Log(LogLevel.Critical, e.Exception.ToLogString(Environment.StackTrace));
            }
            catch (Exception)
            {
                // ignored - do not take chances of causing another exception
            }

            var f = new AppErrorForm {Text = @"Thread Exception"};
            f.ShowDialog();
            Application.Exit();
            
        }
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {

            try
            {
                LogManager.Log(LogLevel.Critical, (e.ExceptionObject as Exception).ToLogString(Environment.StackTrace));
            }
            catch (Exception)
            {
                // ignored - do not take chances of causing another exception
            }

            var f = new AppErrorForm {Text = @"Unhandled Exception"};
            f.ShowDialog();
            Application.Exit();
            
        }
    }
}
