using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranges_examples.Classes
{
    public class MockedData
    {
        public static string ApplicationFileName => "contacts.json";
        public static List<Contacts> ReadContacts()
        {
            try
            {
                var json = File.ReadAllText(ApplicationFileName);
                return JSonHelper.ConvertJSonToObject<List<Contacts>>(json);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }

}
