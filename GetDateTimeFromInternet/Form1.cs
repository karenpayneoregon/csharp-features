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

        private void GetDateTimeButton_Click(object sender, EventArgs e)
        {
            var current = InternetHelpers.LocalTime();
            if (current.HasValue)
            {
                dateTimePicker1.Value = current.Value.Date;
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
