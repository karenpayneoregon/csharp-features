using System;
using System.Windows.Forms;
using ExceptionHandling;

/*
 * TODO Change this namespace to your project namespace
 */
namespace ThreadExceptionWindowsFormsApp
{
    /// <summary>
    /// Rig for unhandled exceptions.
    /// Note Text property set on error form is for demo purposes only
    /// </summary>
    static class Program
    {

        [STAThread]
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Handling UI thread exceptions to the event.
            Application.ThreadException += UnhandledExceptions.Application_ThreadException;

            // For handling non-UI thread exceptions to the event. 
            AppDomain.CurrentDomain.UnhandledException +=
                UnhandledExceptions.CurrentDomain_UnhandledException;

            // Indicates capturing exception has completed
            UnhandledExceptions.OnProcessingCompletedEvent += OnProcessingCompletedEvent;

            // TODO Change this to your startup form
            Application.Run(new Form1());
        }
        /// <summary>
        /// Display window informing application must close
        /// </summary>
        private static void OnProcessingCompletedEvent()
        {
            var f = new AppErrorForm { Text = @"Your title goes here" };
            f.ShowDialog();
            Application.Exit();
        }
    }
}
