using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExceptionHandling;
using ThreadExceptionWindowsFormsApp.Forms;

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
            if (Debugger.IsAttached && ThrowOnCloseCheckBox.Checked)
            {
                throw new NotImplementedException();
            }
        }

        private void BadCastButton_Click(object sender, EventArgs e)
        {
            var badCast = (Label) sender;
            MessageBox.Show(badCast.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var viewForm = new LogViewerForm();
            try
            {
                viewForm.ShowDialog();
            }
            finally
            {
                viewForm.Dispose();
            }
        }

        private void MissingFileButton_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("DoesNotExists");
        }
    }
}
