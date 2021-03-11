using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class QuestTest : Quest
    {
        override public void StartQuest(Character hero)
        {
            Console.WriteLine("Starting Test Quest");
            bool questing = true;
            while (hero.hp > 0 && questing == true)
            {
                Console.WriteLine("Quest Events");
                GUI.AnyButton();
                Console.WriteLine("Exiting Quest");
                questing = false;
            }
            if (hero.hp > 0)
            {
                Console.WriteLine("Quest Sucessful");
            }
            else
            {
                Console.WriteLine("Quest Failure");
            }
        }
    }
}