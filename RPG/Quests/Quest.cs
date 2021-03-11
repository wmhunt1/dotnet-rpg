using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Quest
    {
       public virtual void StartQuest(Character hero)
       {
            Console.WriteLine("Starting Quest");    
       }
    }
}