using System;
using System.Text;
using System.Windows.Forms;
using JsonCodeSamples.Classes;
using JsonCodeSamples.Models;

namespace JsonCodeSamples
{
    /// <inheritdoc />
    public partial class Form1 : Form
    {
        /// <inheritdoc />
        public Form1()
        {
            InitializeComponent();
        }

        private void SerializeShipInfoButton_Click(object sender, EventArgs e)
        {
            var fileName = "Ship1.json";
            
            var (success, createException) = Mockups.singleShipInfo().ModelToJson(fileName);
            if (success)
            {
                var (shippingInfo, readException) = Helpers.JsonToModel<ShippingInfo>(fileName);
                MessageBox.Show(readException == null ? shippingInfo.ToString() : readException.Message);
            }
            else
            {
                MessageBox.Show(createException.Message);
            }
        }

        private void SerializeShipInfoListButton_Click(object sender, EventArgs e)
        {
            var fileName = "ShipList.json";
            
            var (success, createException) = Mockups.ShippingInfoList().ModelToJson(fileName);
            if (success)
            {
                var (shippingInfos, readException) = Helpers.JsonToListModel<ShippingInfo>(fileName);
                if (readException == null)
                {
                    var sb = new StringBuilder();
                    shippingInfos.ForEach(item => sb.AppendLine(item.ToString()));
                    MessageBox.Show(sb.ToString());
                }
                else
                {
                    MessageBox.Show(readException.Message);
                }
                
            }
            else
            {
                MessageBox.Show(createException.Message);
            }

        }

        private void SerializeShipInfoListNestedButton_Click(object sender, EventArgs e)
        {
            var fileName = "ShipListNested.json";

            var (success, createException) = Mockups.ShippingInfoNestedList().ModelToJson(fileName);
            if (success)
            {
                var (shippingInfos, readException) = Helpers.JsonToListModel<ShippingInfo>(fileName);
                if (readException == null)
                {
                    foreach (var shippingInfo in shippingInfos)
                    {
                        Console.WriteLine($"{shippingInfo}");
                        foreach (var somethingNested in shippingInfo.SomethingNested)
                        {
                            Console.WriteLine($@"	{somethingNested.Id}, {somethingNested.Value}");
                        }

                        Console.WriteLine();
                    }

                    MessageBox.Show("See Visual Studio output window for results");

                }
                else
                {
                    MessageBox.Show(readException.Message);
                }

            }
            else
            {
                MessageBox.Show(createException.Message);
            }
        }
    }
}
