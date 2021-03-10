using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class GUI
    {
         public static void AnyButton()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        public static void Title()
        {
            Console.WriteLine("---------- Heroes of The Imperial Federation -----------");
        }
    }
}