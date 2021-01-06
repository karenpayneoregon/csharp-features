using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;


namespace Async_Enumerables
{

    static class Program
    {
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            
            var needToCreateNew = true;
            
            using var mutex = new Mutex(true, ThisNamespace(), out needToCreateNew);
            
            if (needToCreateNew)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Debug.WriteLine(ThisNamespace());
                Application.Run(new Form1());
            }
            else
            {
                var current = Process.GetCurrentProcess();
                
                foreach (var process in Process.GetProcessesByName(current.ProcessName))
                {
                    if (process.Id == current.Id) continue;
                    SetForegroundWindow(process.MainWindowHandle);
                    break;
                }
                
            }
        }
        public static string ThisNamespace()
        {
            var myType = typeof(Program);
            return myType.Namespace;
        }
    }
}
