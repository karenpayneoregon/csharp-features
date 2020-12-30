using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadExceptionWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }

        private void OnShown(object? sender, EventArgs e)
        {
            if (Debugger.IsAttached)
            {
                MessageBox.Show("This does not work while in debug mode");
            }
            else
            {
                Closing += OnClosing;
            }
            
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
