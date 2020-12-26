using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleHelpers.ConsoleColors;

namespace ConsoleHelpers
{
    public static class ConsoleKeysHelper
    {
        public static void WaitReadLine(string message = "Press any key to terminate.")
        {
            WriteSectionBold(message,false);
            Console.ReadLine();
        }
    }
}
