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
        public static string ContactFileName { get; } = "contacts.json";

        public static List<Contacts> ReadContacts()
        {
            try
            {
                var json = File.ReadAllText(ContactFileName);
                return JSonHelper.ConvertJSonToObject<List<Contacts>>(json);
            }
            catch (Exception)
            {
                return null;
            }

        }
    }

}
