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
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            FruitComboBox.DataSource= JsonOperations.Read().Fruits.OrderBy(fruit => fruit.Item).ToList();
        }
    }

public class JsonOperations
{
    public static FruitLoops Read() => 
        JsonConvert.DeserializeObject<FruitLoops>(File.ReadAllText("Fruit.json"));
}
    public class FruitLoops
    {
        public Fruit[] Fruits { get; set; }
    }
    public class Fruit
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int Qty { get; set; }
        public int price { get; set; }
        public override string ToString() => Item;
    }
}
