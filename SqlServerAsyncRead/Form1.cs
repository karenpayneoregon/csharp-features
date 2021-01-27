using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServerAsyncRead.Classes;

namespace SqlServerAsyncRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void LoadProductsButton_Click(object sender, EventArgs e)
        {
            var table = await DataOperations.ReadProductsTask();

            dataGridView1.DataSource = table;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var table = await DataOperations.ReadProductsTask();

            dataGridView1.DataSource = table;
        }
    }
}
