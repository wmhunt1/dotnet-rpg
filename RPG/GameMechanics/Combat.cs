using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Combat
    {
            public void RunCombat(Character char1, Character char2)
            {
                Console.WriteLine($"{char1.name} is in combat with {char2.name}");
                bool combat = true;
                while (char1.hp > 0 && char2.hp > 0 && combat == true)
                {
                    Console.WriteLine("---- Combat ----");
                    Console.WriteLine($"{char1.name}: {char1.hp} VS {char2.name}: {char2.hp}");
                    Console.WriteLine($"[1] Attack {char2.name}");
                    Console.WriteLine("[0] Run!");
                    string userInput = Console.ReadLine();
                    switch (userInput)
                {
                    case "1":
                        Console.WriteLine($"{char1.name} attacks {char2.name} dealing {char1.damage} damage.");
                        char2.hp -= char1.damage;
                        break;
                    case "0":
                        combat = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                    if (combat == true)
                    {
                        Console.WriteLine($"{char2.name} attacks {char1.name} dealing {char2.damage} damage.");
                        char1.hp -= char2.damage;
                    }
                    else
                    {
                        Console.WriteLine($"{char2.name} attacks, dealing {char2.damage} as {char1.name} attempts to flee.");
                        char1.hp -= char2.damage;
                    }
                    GUI.AnyButton();
                }
                if (char1.hp > 0)
                {
                    if (combat == true)
                    {
                        GUI.Announcement($"{char1.name} wins");
                        char1.gainXP(char2.level*10);
                    }
                    else
                    {
                        {
                            GUI.Announcement($"{char1.name} fled.");
                        }
                    }
                }
                else
                {
                    GUI.Announcement($"{char1.name} loses");
                }
            }
    }
}