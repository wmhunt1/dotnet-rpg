using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{

    public class GameMenu
    {
        public Character hero = new Character("Hero", "Your PC", 1);
        public ValleyMap valleyMap = new ValleyMap();
        public VillageMap villageMap = new VillageMap();
        public WorldMap worldMap = new WorldMap();

        private bool playingGame;
        public bool PlayingGame { get { return this.playingGame; } set { this.playingGame = value; } }
        public void DisplayGameMenu()
        {
            GUI.AnyButton();
            playingGame = true;
            while (playingGame == true)
            {
                {
                    GUI.Title("------------------------------ Heroes of The Imperial Federation -------------------------------");
                    Console.WriteLine("[1] Character Sheet [2] Inventory [3] Journal [4] World Map [8] Quest Test [9] Combat Test [0] Main Menu");
                    valleyMap.DisplayMapName();
                    valleyMap.ViewMap();
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
                            worldMap.DisplayMapName();
                            worldMap.ViewMap();
                            AnyButton();
                            break;
                        case "8":
                            QuestTest newQuestTest = new QuestTest();
                            newQuestTest.StartQuest(hero);
                            break;
                        case "9":
                            CombatTest newCombatTest = new CombatTest();
                            newCombatTest.RunCombatTest(hero);
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