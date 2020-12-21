using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageConverterSample.LanguageExtensions;
using ImageHelpers;

namespace ImageConverterSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Shown += OnFormShown;
        }

        private void OnFormShown(object? sender, EventArgs e)
        {
            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Icons", "agent1.ico");

            Agent1PictureBox.Image = Converters.FromBytesToBitMap(fileName);

            fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Icons", "Csharp.ico");
            cSharpPictureBox.Image = Converters.FromBytesToBitMap(fileName);

            fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Icons", "Excel.ico");
            // use extension method
            ExcelPictureBox.LoadIconFromFile(fileName);
        }
    }
}
