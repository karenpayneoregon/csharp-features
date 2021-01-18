using ClearControlsWindowsForms.Extensions;
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

namespace ClearControlsWindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            tableLayoutPanel1.Controls.OfType<CheckBox>().ToList()
                .ForEach(cb => cb.CheckStateChanged += OnCheckStateChanged);
        }

        private void OnCheckStateChanged(object sender, EventArgs e)
        {
            if (_working)
            {
                return;
            }
            
            var cb = (CheckBox)sender;
            if (cb.Checked) return;
            
            var checkBoxIndex = cb.Name.GetInt() ;
            var checkBoxes = tableLayoutPanel1.Controls.OfType<CheckBox>().ToList();

            foreach (var checkBox in checkBoxes)
            {
                var cbIndex = checkBox.Name.GetInt();
                if (cbIndex <= checkBoxIndex)
                {
                    checkBox.Checked = true;
                    
                }
                else
                {
                    checkBox.Enabled = false;
                    var tagIndex = Convert.ToInt32(checkBox.Tag);
                    
                    var controls = tableLayoutPanel1
                        .Controls.OfType<ComboBox>()
                        .Where(c => Convert.ToInt32(c.Tag) == tagIndex);
                    
                    foreach (var comboBox in controls)
                    {
                        comboBox.Enabled = false;
                    }
                    
                }
            }

        }

        private bool _working;
        private void ResetButton_Click(object sender, EventArgs e)
        {
            _working = true;
            
            foreach (var control in tableLayoutPanel1.Controls.OfType<ComboBox>())
            {
                control.Enabled = true;
            }
            
            foreach (var control in tableLayoutPanel1.Controls.OfType<CheckBox>())
            {
                control.Enabled = true;
                control.Checked = false;
            }

            _working = false;
        }
    }


}
