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
using ParsingArray.Extensions;

namespace ParsingArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            
            var stringValues = textBox1.ToStringArray();

            // optional
            //if (!stringValues.AllDecimals()) return;
            var result = stringValues.ToDecimalArray().ItemsFromArray().MaxItem();
            if (result != null) stringValues[result.Index] = "H";

            listBox1.Items.AddRange(stringValues);

        }
    }
}
