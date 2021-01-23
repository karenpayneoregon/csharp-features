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
            var result = stringValues.ToDecimalArray().ItemsFromArray().MaxItem();
            if (result != null) stringValues[result.Index] = "H";

            listBox1.Items.AddRange(stringValues);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var stringValues = textBox1.ToStringArray();

            var itemList = stringValues
                .ToDecimalArray()
                .ItemsFromArray()
                .OrderByDescending(item => item.Value)
                .ToList();
            
            for (int index = itemList.Count - 1; index >= 0; --index)
            {
                itemList[index].Text = $"H{index + 1}";
            }

            foreach (var item in itemList)
            {
                Debug.WriteLine($"{item.Text}\t{item.Value}");
            }
        }
    }
}
