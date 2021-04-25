using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JsonCodeSamples.Classes;
using JsonCodeSamples.Models;

namespace JsonCodeSamples
{
    public partial class Form1 : Form
    {
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
                
            }
            else
            {
                MessageBox.Show(createException.Message);
            }

        }
    }
}
