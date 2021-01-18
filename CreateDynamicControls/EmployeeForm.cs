using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreateDynamicControls.Classes;
using CreateDynamicControls.Classes.Extensions;

namespace CreateDynamicControls
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void IterateButton_Click(object sender, EventArgs e)
        {
            var employee = DataOperations.ReadEmployees().FirstOrDefault();
            employee.EmployeeProperties();


        }
    }
}
