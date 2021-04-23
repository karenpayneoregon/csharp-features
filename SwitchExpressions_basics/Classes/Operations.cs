using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SwitchExpressions_basics.Extensions;
using static System.Console;
using static ConsoleHelpers.ConsoleColors;

namespace SwitchExpressions_basics.Classes
{
    public class Operations
    {

        [ModuleInitializer]
        public static void InitOne() => WriteHeader("Switch examples");

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
        /// <summary>
        /// Invoke action dependent on contact type
        /// </summary>
        /// <param name="contactType"></param>
        /// <returns></returns>
        public static Action ContactTypeAction(ContactType contactType) => contactType switch
        {
            ContactType.AccountingManager => AccountingManagerMethod,
            ContactType.AssistantSalesAgent => AssistantSalesAgentMethod, 
            ContactType.AssistantSalesRepresentative => AssistantSalesRepresentativeMethod,
            ContactType.MarketingAssistant => MarketingAssistantMethod,  
            ContactType.MarketingManager => MarketingManagerMethod,
            ContactType.OrderAdministrator => OrderAdmin, 
            ContactType.OwnerMarketingAssistant => OwnerMarketingAssistantMethod,
            ContactType.Owner => OwnerMethod, 
            ContactType.SalesAgent => SalesAgentMethod,
            ContactType.SalesAssociate => SalesAssociateMethod,
            ContactType.SalesManager => SalesManagerMethod, 
            ContactType.SalesRepresentative  => SalesRepresentativeMethod,
            ContactType.VicePresidentSales => VicePresidentMethod,
            _ => ContactTypeDefaultMethod
        };

        private static void AccountingManagerMethod() => WriteLine("Accounting manager method");
        private static void AssistantSalesRepresentativeMethod() => WriteLine("Assistant Sales Representative method");
        private static void AssistantSalesAgentMethod() => WriteLine("Assistant sales agent method");
        private static void ContactTypeDefaultMethod() => WriteLine($"Unknown contact type");
        private static void SalesAgentMethod() => WriteLine("Sales Agent method");
        private static void SalesRepresentativeMethod() => WriteLine("Sales Representative method");
        private static void MarketingManagerMethod() => WriteLine("Marketing Manager method");
        /// <summary>
        /// Let's do some more work than the others
        /// </summary>
        private static void OwnerMethod()
        {

            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Owner.txt");
            File.WriteAllText(fileName, "An owner");
            
            WriteLine("Owner method");
            
        }
        private static void OrderAdmin() => WriteLine("Order Administrator method");
        private static void OwnerMarketingAssistantMethod() => WriteLine("Owner Marketing Assistant method");
        private static void SalesAssociateMethod() => WriteLine("Sales Associate method");
        private static void VicePresidentMethod() => WriteLine("VP method");
        private static void SalesManagerMethod() => WriteLine("Sales Manager method");
        private static void MarketingAssistantMethod() => WriteLine("Marketing assistant method");

        /// <summary>
        /// Working with Func
        /// </summary>
        public static Func<ContactType, string> ContactTypeFunc = contactType =>
        {
            return contactType switch
            {
                ContactType.AccountingManager => "AM",
                ContactType.AssistantSalesAgent => "ASG",
                ContactType.AssistantSalesRepresentative => "ADR",
                _ => "Unknown"
            };
        };

        #region Stackoverflow question
        /// <summary>
        /// https://stackoverflow.com/questions/67231144/c-sharp-convert-sql-query-with-case-statement-to-linq
        /// </summary>
        public static void TestMe()
        {
            var projet = new ProjectItem() { IdPlateforme = 1, IdPlateformeSecteur = 2 };

            projet.IdSecteur = SetIdSecteur(projet);
            Debug.WriteLine(projet.IdPlateformeSecteur);
        }

        private static int SetIdSecteur(ProjectItem sender) => sender.IdPlateforme switch
        {
            1 when sender.IdSecteur == 1 => 1,
            1 when sender.IdSecteur == 2 => 2,
            1 when sender.IdSecteur == 4 => 3,
            3 when sender.IdSecteur == 1 => 4,
            3 when sender.IdSecteur == 2 => 5,
            3 when sender.IdSecteur == 4 => 6,
            2 when sender.IdSecteur == 1 => 7,
            2 when sender.IdSecteur == 2 => 8,
            2 when sender.IdSecteur == 4 => 9,
            _ => sender.IdPlateformeSecteur
        };

        #endregion
    }
}
