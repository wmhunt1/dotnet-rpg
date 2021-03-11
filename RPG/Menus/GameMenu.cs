using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{

    public class GameMenu
    {
        public Character hero = new Character("Hero", "Your PC", 1);

        private bool playingGame;
        public bool PlayingGame { get { return this.playingGame; } set { this.playingGame = value; } }
        public void DisplayGameMenu()
        {
            playingGame = true;
            while (playingGame == true)
            {
                {
                    GUI.Title("------------------------------ Heroes of The Imperial Federation -------------------------------");
                    Console.WriteLine("[1] Character Sheet [2] Inventory [3] Journal [4] World Map [9] Combat Test [0] Main Menu");
                    string userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            ViewCharacterSheet();
                            break;
                        case "2":
                            Console.WriteLine("Viewing Inventory");
                            break;
                        case "3":
                            Console.WriteLine("Viewing Journal");
                            break;
                        case "4":
                            Console.WriteLine("Viewing World Map");
                            break;
                        case "9":
                            CombatTest newCombatTest = new CombatTest();
                            newCombatTest.RunCombatTest(hero);
                            //CombatTest();
                            break;
                        case "0":
                            playingGame = false;
                            Console.WriteLine("Returning to Main Menu");
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
            }
        }
        public void ViewCharacterSheet()
        {
            Console.WriteLine("---- Character Sheet ----");
            Console.WriteLine(hero.ToString());
            GUI.AnyButton();
        }
    }
}