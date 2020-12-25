﻿using System;
using static ConsoleHelpers.ConsoleColors;
using SwitchExpressions_basics.Classes;

namespace SwitchExpressions_basics
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteHeader("Switch examples");

            WriteSectionBold("Conventional Switch");
            Conventional1(2);
            EmptyLine();

            WriteSectionBold("Conventional2");
            EnvironmentData.CostCenter = "700";
            Console.WriteLine(Conventional2());
            EmptyLine();

            WriteSectionBold("ExpressionBodiedMember 1");
            ExpressionBodiedMember1(1);
            EmptyLine();


            WriteSectionBold("ExpressionBodiedMember 2");
            Console.WriteLine(ExpressionBodiedMember2());
            EmptyLine();

            WriteSectionBold("ExpressionBodiedMember 3");
            ExpressionBodiedMember3();
            Console.WriteLine(EnvironmentData.UserAddress);
            EmptyLine();


            Console.ReadLine();
        }

        /// <summary>
        /// Any version of C#
        /// </summary>
        /// <param name="caseSwitch"></param>
        private static void Conventional1(int caseSwitch)
        {

            switch (caseSwitch)
            {
                case 1:
                    Operations.Case1();
                    break;
                case 2:
                    Operations.Case2();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
        }

        /// <summary>
        /// C# 8, 9
        /// </summary>
        /// <param name="caseSwitch"></param>
        private static void ExpressionBodiedMember1(int caseSwitch) =>
            (
                caseSwitch switch
                {
                    1 => (Action)Operations.Case1,
                    2 => Operations.Case2,
                    _ => throw new ArgumentOutOfRangeException()
                })
            ();

        public static string Conventional2()
        {
            string userAddress;

            switch (EnvironmentData.CostCenter)
            {
                case "040":
                    userAddress = "P O BOX 14135 * SALEM, OR  97309-5068\r\n(877) 345 - 3484 or Fax(503) 947 - 1335\r\n";
                    break;
                case "042":
                case "043":
                    userAddress = "875 Union Street NE * SALEM, OR  97311\r\n(503) 947-1669 or Fax (503) 947-1668\r\n";
                    break;
                case "044":
                    userAddress = "P O BOX 14130 * SALEM, OR  97309-5046\r\n(503) 947-1995 or Fax (503) 947-1811\r\n";
                    break;
                case "045":
                    userAddress = "PO BOX 14518 * Salem, Oregon  97309\r\n(800) 436-6191 or Fax (877) 353-7700\r\n";
                    break;
                case "200":
                    userAddress = "PO Box 14135 * Salem, Oregon  97309 5068\r\n(503) 292-2057 or (877) 345-3484 (in Oregon)\r\n" + 
                                  "(877) 345-3484 (outside Oregon) or Fax to (866) 345-1878";
                    break;
                case "300":
                    userAddress = "PO Box 14135 * Salem, Oregon  97309 5068\r\n(877) 345-3484 or Fax to (866) 345-1878";
                    break;
                case "700":
                    userAddress = "PO Box 14135 * Salem, Oregon  97309 5068\r\n(541) 388-6207 or (877) 345-3484 (in Oregon)\r\n" + 
                                  "(877) 345-3484 (outside Oregon) or Fax to (866) 345-1878";
                    break;
                case "990":
                    userAddress = "PO Box 14135 * Salem, Oregon  97309 5068\r\n(503) 292-2057 or (877) 345-3484 (in Oregon)\r\n" + 
                                  "(877) 345-3484 (outside Oregon) or Fax to (866) 345-1878";
                    break;
                default:
                    userAddress = "875 Union Street NE\r\nSalem, OR  97311\r\n(800) 237-3710, Fax to (866) 345-1878";
                    break;
            }

            EnvironmentData.UserAddress = userAddress;

            return userAddress;
            
        }
        public static string ExpressionBodiedMember2()
        {
            string userAddress = EnvironmentData.CostCenter switch
            {
                "040" => "P O BOX 14135 * SALEM, OR  97309-5068\r\n(877) 345 - 3484 or Fax(503) 947 - 1335\r\n",
                "042" => "875 Union Street NE * SALEM, OR  97311\r\n(503) 947-1669 or Fax (503) 947-1668\r\n",
                "043" => "875 Union Street NE * SALEM, OR  97311\r\n(503) 947-1669 or Fax (503) 947-1668\r\n",
                "044" => "P O BOX 14130 * SALEM, OR  97309-5046\r\n(503) 947-1995 or Fax (503) 947-1811\r\n",
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

            EnvironmentData.UserAddress = userAddress;

            return userAddress;
        }
        public static void ExpressionBodiedMember3() {
            EnvironmentData.UserAddress = EnvironmentData.CostCenter switch
            {
                "040" => "P O BOX 14135 * SALEM, OR  97309-5068\r\n(877) 345 - 3484 or Fax(503) 947 - 1335\r\n",
                "042" or "043" => "875 Union Street NE * SALEM, OR  97311\r\n(503) 947-1669 or Fax (503) 947-1668\r\n",
                "044" => "P O BOX 14130 * SALEM, OR  97309-5046\r\n(503) 947-1995 or Fax (503) 947-1811\r\n",
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