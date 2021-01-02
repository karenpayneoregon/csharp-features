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
using ThreadExceptionWindowsFormsApp.Helpers;

namespace ThreadExceptionWindowsFormsApp
{
    /// <summary>
    /// Rig for unhandled exceptions.
    /// Note Text property set on error form is for demo purposes only
    /// </summary>
    static class Program
    {

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
            Application.ThreadException += UnhandledExceptions.Application_ThreadException;

            // For handling non-UI thread exceptions to the event. 
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptions.CurrentDomain_UnhandledException;
            
            Application.Run(new Form1());
        }


    }
}
