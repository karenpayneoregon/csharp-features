using System;
using System.Net.Mime;
using static ConsoleHelpers.ConsoleColors;
using SwitchExpressions_basics.Classes;
using SwitchExpressions_basics.Extensions;
using static ConsoleHelpers.ConsoleKeysHelper;

namespace SwitchExpressions_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            EnvironmentData.CostCenter = "700";

            WriteSectionBold("Conventional Switch");
            Conventional1(2);
            EmptyLine();

            WriteSectionBold("Conventional2");
            Console.WriteLine(Conventional2());
            EmptyLine();

            WriteSectionBold("ExpressionBodiedMember 1");
            ExpressionBodiedMember1_int(1);
            EmptyLine();


            WriteSectionBold("ExpressionBodiedMember 2");
            Console.WriteLine(ExpressionBodiedMember2());
            EmptyLine();

            WriteSectionBold("ExpressionBodiedMember 3");
            ExpressionBodiedMember3();
            Console.WriteLine(EnvironmentData.UserAddress);
            EmptyLine();

            EnvironmentData.CostCenter = "043";
            WriteSectionBold("ExpressionBodiedMember using Operations class method");
            Operations.ExpressionBodiedMember();
            Console.WriteLine(EnvironmentData.UserAddress);
            EmptyLine();

            WriteSectionBold("Case When int");
            Operations.CaseWhen(5);
            EmptyLine();

            WriteSectionBold("Delegate no params");
            DelegatesContactType();
            EmptyLine();

            WriteSectionBold("Contact type Func<ContactType, string>");
            DelegateContactTypeFunc();
            EmptyLine();

            ReadLineWithTimeout(TimeSpan.FromSeconds(20), "Press any key to terminate.");
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
                    throw new ArgumentOutOfRangeException("Dude, unknown int for case");
            }
            
        }

        /// <summary>
        /// C# 8, 9
        /// </summary>
        /// <param name="caseSwitch">int</param>
        private static void ExpressionBodiedMember1_int(int caseSwitch) =>
            (
                caseSwitch switch
                {
                    1 => (Action)Operations.Case1,
                    2 => Operations.Case2,
                    _ => throw new ArgumentOutOfRangeException("Dude, unknown int for case")
                })
            ();

        /// <summary>
        /// C# 8, 9
        /// </summary>
        /// <param name="caseSwitch">ApplicationRoles</param>
        private static void ExpressionBodiedMember1_enum(ApplicationRoles caseSwitch) =>
            (
                caseSwitch switch
                {
                    ApplicationRoles.User => (Action)Operations.Case1,
                    ApplicationRoles.Admin => Operations.Case2,
                    _ => throw new ArgumentOutOfRangeException("Dude, unknown member for case")
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
        public static string Conventional2_if()
        {
            string userAddress;

            if (EnvironmentData.CostCenter == "040")
                userAddress = "P O BOX 14135 * SALEM, OR  97309-5068\r\n(877) 345 - 3484 or Fax(503) 947 - 1335\r\n";
            else if (EnvironmentData.CostCenter == "042" || EnvironmentData.CostCenter == "043")
                userAddress = "875 Union Street NE * SALEM, OR  97311\r\n(503) 947-1669 or Fax (503) 947-1668\r\n";
            else if (EnvironmentData.CostCenter == "044")
                userAddress = "P O BOX 14130 * SALEM, OR  97309-5046\r\n(503) 947-1995 or Fax (503) 947-1811\r\n";
            else if (EnvironmentData.CostCenter == "045")
                userAddress = "PO BOX 14518 * Salem, Oregon  97309\r\n(800) 436-6191 or Fax (877) 353-7700\r\n";
            else if (EnvironmentData.CostCenter == "200")
                userAddress = "PO Box 14135 * Salem, Oregon  97309 5068\r\n(503) 292-2057 or (877) 345-3484 (in Oregon)\r\n" +
                              "(877) 345-3484 (outside Oregon) or Fax to (866) 345-1878";
            else if (EnvironmentData.CostCenter == "300")
                userAddress = "PO Box 14135 * Salem, Oregon  97309 5068\r\n(877) 345-3484 or Fax to (866) 345-1878";
            else if (EnvironmentData.CostCenter == "700")
                userAddress = "PO Box 14135 * Salem, Oregon  97309 5068\r\n(541) 388-6207 or (877) 345-3484 (in Oregon)\r\n" +
                              "(877) 345-3484 (outside Oregon) or Fax to (866) 345-1878";
            else if (EnvironmentData.CostCenter == "990")
                userAddress = "PO Box 14135 * Salem, Oregon  97309 5068\r\n(503) 292-2057 or (877) 345-3484 (in Oregon)\r\n" +
                              "(877) 345-3484 (outside Oregon) or Fax to (866) 345-1878";
            else
                userAddress = "875 Union Street NE\r\nSalem, OR  97311\r\n(800) 237-3710, Fax to (866) 345-1878";

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
                _ => 
                "875 Union Street NE\r\nSalem, OR  97311\r\n(800) 237-3710, Fax to (866) 345-1878"
            };

            EnvironmentData.UserAddress = userAddress;

            return userAddress;
        }
        /// <summary>
        /// Demonstrates checking for multiple conditions with same result
        /// </summary>
        /// <returns></returns>
        public static void ExpressionBodiedMember2Secondary()
        {
            EnvironmentData.UserAddress = EnvironmentData.CostCenter switch
            {
                var value when value.InCondition("043","044") => 
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
                _ => 
                    "875 Union Street NE\r\nSalem, OR  97311\r\n(800) 237-3710, Fax to (866) 345-1878"
            };

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

        public static void ExpressionBodiedMemberConditional()
        {

            EnvironmentData.UserAddress = 
                EnvironmentData.CostCenter is "040" ? "P O BOX 14135 * SALEM, OR  97309-5068\r\n(877) 345 - 3484 or Fax(503) 947 - 1335\r\n" :
                EnvironmentData.CostCenter is "042" or "043" ? "875 Union Street NE * SALEM, OR  97311\r\n(503) 947-1669 or Fax (503) 947-1668\r\n" :
                EnvironmentData.CostCenter is "044" ? "P O BOX 14130 * SALEM, OR  97309-5046\r\n(503) 947-1995 or Fax (503) 947-1811\r\n" :
                EnvironmentData.CostCenter is "045" ? "PO BOX 14518 * Salem, Oregon  97309\r\n(800) 436-6191 or Fax (877) 353-7700\r\n" :
                EnvironmentData.CostCenter is "200" ? "PO Box 14135 * Salem, Oregon  97309 5068\r\n(503) 292-2057 or (877) 345-3484 (in Oregon)\r\n" +
                                                      "(877) 345-3484 (outside Oregon) or Fax to (866) 345-1878" :
                EnvironmentData.CostCenter is "300" ? "PO Box 14135 * Salem, Oregon  97309 5068\r\n(877) 345-3484 or Fax to (866) 345-1878" :
                EnvironmentData.CostCenter is "700" ? "PO Box 14135 * Salem, Oregon  97309 5068\r\n(541) 388-6207 or (877) 345-3484 (in Oregon)\r\n" +
                                                      "(877) 345-3484 (outside Oregon) or Fax to (866) 345-1878" :
                EnvironmentData.CostCenter is "990" ? "PO Box 14135 * Salem, Oregon  97309 5068\r\n(503) 292-2057 or (877) 345-3484 (in Oregon)\r\n" +
                                                      "(877) 345-3484 (outside Oregon) or Fax to (866) 345-1878" : "875 Union Street NE\r\nSalem, OR  97311\r\n(800) 237-3710, Fax to (866) 345-1878";

        }

        /// <summary>
        /// Code sample for Action
        /// </summary>
        public static void DelegatesContactType()
        {

            foreach (ContactType contactType in Enum.GetValues<ContactType>())
            {
                Action contactTypeAction = Operations.ContactTypeAction(contactType);
                contactTypeAction.Invoke();
            }

            
        }
        /// <summary>
        /// Code sample for using Func
        /// </summary>
        public static void DelegateContactTypeFunc()
        {
            Console.WriteLine(Operations.ContactTypeFunc(ContactType.AccountingManager));
        }
        
    }
}
