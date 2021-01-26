using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControlsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            checkBoxCustom1.Id = 12;
        }

        
        private void GetCheckBoxIdentifierButton_Click(object sender, EventArgs e)
        {
            if (checkBoxCustom1.HasId)
            {
                MessageBox.Show($"Id is {checkBoxCustom1.Id}");
            }
            else
            {
                MessageBox.Show("No id");
            }

        }

        private void GetTextBoxIdentifierButton_Click(object sender, EventArgs e)
        {
            if (textBoxCustom1.HasId)
            {
                MessageBox.Show($"Id is {textBoxCustom1.Id}");
            }
            else
            {
                MessageBox.Show("No id set for text box, press OK to set");
                textBoxCustom1.Id = 1;
            }
        }
    }
}
