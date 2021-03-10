using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{

    public class GameMenu
    {
        //Character newHero = hero;
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
            //Console.WriteLine(hero.ToString());
            GUI.AnyButton();
        }
        // public void CombatTest()
        // {
        //     Character goblin = new Character("Goblin", "A Goblin", 1);
        //     goblin.hp = 5;
        //     Combat newCombat = new Combat();
        //     newCombat.RunCombat(newHero, goblin);
        // }
    }
}