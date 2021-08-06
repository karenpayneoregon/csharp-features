using System;
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
