﻿using System;
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
        
        /// <summary>
        /// Setup for causing an exception on closing this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnShown(object? sender, EventArgs e)
        {
            if (Debugger.IsAttached)
            {
                MessageBox.Show(@"This does not work while in debug mode");
            }
            else
            {
                Closing += OnClosing;
            }
            
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

    }
}
