using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithClasses
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Student> _bindingList = new BindingList<Student>();
        public Form1()
        {
            InitializeComponent();

            
            listBox1.DataSource = _bindingList;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                _bindingList.Add(new Student() { Name = NameTextBox.Text });
            }
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex <= -1) return;
            
            var student = _bindingList[listBox1.SelectedIndex];
            MessageBox.Show(student.Name);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex <= -1) return;
            _bindingList[listBox1.SelectedIndex].Name = "Karen";
            listBox1.Invalidate();
        }
    }

    public class Student : INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public Student Highest(Student o1, Student o2) => 
            string.Compare(
                o1.ToString(), 
                o2.ToString(), StringComparison.Ordinal) > 0 ? o1 : o2;
        
        public override string ToString() => Name;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
    
}
