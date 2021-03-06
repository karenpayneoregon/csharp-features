﻿using System.Windows.Forms;

namespace ThreadExceptionWindowsFormsApp.Helpers
{
    public static class Dialogs
    {
        public static bool Question(string text)
        {
            return (MessageBox.Show(
                text,
                Application.ProductName,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        }
    }
}