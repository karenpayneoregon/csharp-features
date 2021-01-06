using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadExceptionWindowsFormsApp.Classes;
using ThreadExceptionWindowsFormsApp.Forms;
using static ThreadExceptionWindowsFormsApp.Helpers.CueBannerTextCode;

namespace ThreadExceptionWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }
        
        /// <summary>
        /// Setup for causing an exception on closing this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnShown(object? sender, EventArgs e)
        {

            if (Debugger.IsAttached)
            {

                if (Environment.UserName != "PayneK")
                {
                    MessageBox.Show(@"This does not work while in debug mode");
                }
                
            }
            else
            {
                Closing += OnClosing;
            }
            
            SetCueText(CustomExceptionTextTextBox,"Enter text to throw exception");
            
        }
        
        /// <summary>
        /// Throw exception if CheckBox is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClosing(object sender, CancelEventArgs e)
        {
            if (Debugger.IsAttached && ThrowOnCloseCheckBox.Checked)
            {
                throw new NotImplementedException();
            }
        }
        /// <summary>
        /// View log file if exists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewLogButton_Click(object sender, EventArgs e)
        {
            LogViewerForm viewForm = new();
            
            try
            {
                viewForm.ShowDialog();
            }
            finally
            {
                viewForm.Dispose();
            }
        }
        /// <summary>
        /// Cause an unhandled exception for file not found
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MissingFileButton_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("DoesNotExists");
        }
        
        /// <summary>
        /// Cause an unhandled exception with invalid cast
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BadCastButton_Click(object sender, EventArgs e)
        {
            var badCast = (Label)sender;
            MessageBox.Show(badCast.Text);
        }

        private void BadThreadButton_Click(object sender, EventArgs e)
        {
            Thready.Start();
        }

        private void MyExceptionButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomExceptionTextTextBox.Text))
            {
                CustomExceptionTextTextBox.Text = "Well here we go";
            }

            throw new ApplicationException(CustomExceptionTextTextBox.Text);
        }

        private void ArgumentNullExceptionButton_Click(object sender, EventArgs e)
        {
            /*
             * This will work as expected
             */
            var firstName = "KAREN";
            MessageBox.Show(NoNullExample(firstName));
            
            /*
             * This will throw a runtime exception
             */
            firstName = null;
            MessageBox.Show(NoNullExample(firstName));
        }
        /// <summary>
        /// Passing a null string will throw a runtime exception. Note that if
        /// this method could handle a null value via assertion than that is
        /// an option while currently we would assert before calling this method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string NoNullExample([NotNull] string value) => value.ToLower();

        
    }
   

}
