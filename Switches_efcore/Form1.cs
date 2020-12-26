using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Switches.Classes;

namespace Switches
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            SchoolOperations.OnIteratePersonGradesEvent += SchoolOperationsOnOnIteratePersonGradesEvent;
        }

        private void SchoolOperationsOnOnIteratePersonGradesEvent(PersonGrades pData)
        {
            if (pData.Grade is null) return;
            
            var item = new ListViewItem(new[]
            {
                pData.PersonID.ToString(), 
                pData.FullName, 
                pData.Grade.Value.ToString(CultureInfo.CurrentCulture), 
                pData.GradeLetter
            });

            listView1.Items.Add(item);
        }


        private void StudentGradesButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SchoolOperations.GradesForPeople(2021);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
