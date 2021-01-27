using System;
using static ChangeFileExtensions.FileHelpers;

namespace ChangeFileExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            RenameExtensions(AppDomain.CurrentDomain.BaseDirectory,"text","txt");
        }
    }
}
