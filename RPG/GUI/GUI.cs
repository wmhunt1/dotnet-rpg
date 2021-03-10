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
         public static void Title(String str)
       {
           Console.ForegroundColor = ConsoleColor.Cyan;
           str = String.Format("{0}\n", str);
           Console.Write(str);
           Console.ResetColor();
       } 
         public static void Announcement(String str)
       {
            Console.ForegroundColor = ConsoleColor.Yellow;
            str = String.Format("\t({0})!\n", str);
            Console.Write(str);
            Console.ResetColor();
       }
    }
}