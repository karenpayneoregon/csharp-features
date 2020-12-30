using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExceptionHandling;

namespace ThreadExceptionWindowsFormsApp
{
    static class Program
    {
        private static readonly string ExceptionFileName = Path
            .Combine(AppDomain.CurrentDomain.BaseDirectory, "UnhandledException.txt");
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.Run(new Form1());
        }
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                var builder = new StringBuilder();
                if (File.Exists(ExceptionFileName))
                {
                    builder.AppendLine(File.ReadAllText(ExceptionFileName));
                }

                builder.AppendLine(e.Exception.ToLogString(Environment.StackTrace));
                File.WriteAllText(ExceptionFileName, builder.ToString());
            }
            catch (Exception)
            {
                // ignored
            }


            Application.Exit();
        }
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {

            try
            {
                var builder = new StringBuilder();
                if (File.Exists(ExceptionFileName))
                {
                    builder.AppendLine(File.ReadAllText(ExceptionFileName));
                }

                builder.AppendLine((e.ExceptionObject as Exception).ToLogString(Environment.StackTrace));
                File.WriteAllText(ExceptionFileName, builder.ToString());
            }
            catch (Exception)
            {
                // ignored
            }


            Application.Exit();
        }
    }
}
