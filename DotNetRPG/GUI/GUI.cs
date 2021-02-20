using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    public class GUI
    {
       public static String Title(String str)
       {
           str = String.Format("==== {0} ====\n\n", str);
           return str;
       } 
         public static String MenuTitle(String str)
       {
            str = String.Format("=== {0}\n", str);
            return str;
       }
       public static String MenuOption(int index, String str)
       {
            str = String.Format("- ({0}) : {1} :\n", index, str);
            return str;
       }
         public static String Announcement(String str)
       {
            str = String.Format(" ~ ({0})!\n", str);
            return str;
       }
       public static String GetInput(String str)
       {
            str = String.Format(" - {0} :", str);
            return str;
       }
    }
}