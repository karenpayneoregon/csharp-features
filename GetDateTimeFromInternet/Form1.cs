using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetDateTimeFromInternet.Classes;

namespace GetDateTimeFromInternet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Get local date time from the Internet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetDateTimeButton_Click(object sender, EventArgs e)
        {
            var current = InternetHelpers.LocalTime();
            if (current.HasValue)
            {
                dateTimePicker1.Value = current.Value.Date;
                TimeTextBox.Text = $"{current.Value:T}";
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
