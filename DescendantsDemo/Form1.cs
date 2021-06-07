using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DescendantsDemo.Classes;

namespace DescendantsDemo
{
    public partial class Form1 : Form
    {
        private List<TextBox> _textBoxes = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            _textBoxes.Add(textBox1);
            _textBoxes.Add(textBox2);
        }

        private void CountButton1_Click(object sender, EventArgs e)
        {
            label1.Text = $"Total: {Controls.OfType<TextBox>().Count()}";
            
            
        }

        private void CountButton2_Click(object sender, EventArgs e)
        {
            label1.Text = $@"Total: {Controls.OfType<TextBox>().Where(textBox => textBox.Text == "Karen").Count()}";
            
        }
    }
}
