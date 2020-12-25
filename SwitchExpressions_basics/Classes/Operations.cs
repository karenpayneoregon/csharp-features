using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SwitchExpressions_basics.Classes
{
    public class Operations
    {
        public static void Case1()
        {
            WriteLine("Case 1");
            
        }

        public static void Case2()
        {
            WriteLine("Case 2");
        }
        /// <summary>
        /// Case when with object pattern matching
        /// </summary>
        /// <param name="sender"></param>
        public static void CaseWhen(int sender)
        {
            switch (sender)
            {
                case { } value when (value >= 7):
                    WriteLine($"I am 7 or above: {value}");
                    break;

                case { } value when (value >= 4 && value <= 6):
                    WriteLine($"I am between 4 and 6: {value}");
                    break;

                case { } value when (value <= 3):
                    WriteLine($"I am 3 or less: {value}");
                    break;
            }
        }

        public static void ExpressionBodiedMember()
        {
            EnvironmentData.UserAddress = EnvironmentData.CostCenter switch
            {
                var value when value.InCondition("043", "044") =>
                    "875 Union Street NE * SALEM, OR  97311\r\n(503) 947-1669 or Fax (503) 947-1668\r\n",
                "040" => "P O BOX 14135 * SALEM, OR  97309-5068\r\n(877) 345 - 3484 or Fax(503) 947 - 1335\r\n",
                "042" => "875 Union Street NE * SALEM, OR  97311\r\n(503) 947-1669 or Fax (503) 947-1668\r\n",
                "045" => "PO BOX 14518 * Salem, Oregon  97309\r\n(800) 436-6191 or Fax (877) 353-7700\r\n",
                "200" => "PO Box 14135 * Salem, Oregon  97309 5068\r\n(503) 292-2057 or (877) 345-3484 (in Oregon)\r\n" +
                         "(877) 345-3484 (outside Oregon) or Fax to (866) 345-1878",
                "300" => "PO Box 14135 * Salem, Oregon  97309 5068\r\n(877) 345-3484 or Fax to (866) 345-1878",
                "700" => "PO Box 14135 * Salem, Oregon  97309 5068\r\n(541) 388-6207 or (877) 345-3484 (in Oregon)\r\n" +
                         "(877) 345-3484 (outside Oregon) or Fax to (866) 345-1878",
                "990" => "PO Box 14135 * Salem, Oregon  97309 5068\r\n(503) 292-2057 or (877) 345-3484 (in Oregon)\r\n" +
                         "(877) 345-3484 (outside Oregon) or Fax to (866) 345-1878",
                _ => "875 Union Street NE\r\nSalem, OR  97311\r\n(800) 237-3710, Fax to (866) 345-1878"
            };

        }

    }
}
