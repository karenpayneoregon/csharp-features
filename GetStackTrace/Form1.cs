using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetStackTrace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

#if DEBUG
            Demo1Button.Enabled = true;
            Demo2Button.Enabled = true;
#endif
            
        }

        private void Demo1Button_Click(object sender, EventArgs e)
        {
            try
            {
                FileOperations.CauseError1();
            }
            catch (Exception exception)
            {
                exception.Write();
            }
        }

        private void Demo2Button_Click(object sender, EventArgs e)
        {
            try
            {
                FileOperations.Step1();
            }
            catch (Exception exception)
            {
                exception.Write();
            }
        }
    }
}
