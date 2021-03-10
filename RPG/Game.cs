using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Game
    {
        Character hero = new Character("Hero", "The Hero", 1);
        private bool end;
        private bool playingGame;
        public bool End { get {return this.end;} set {this.end = value;} }
        public bool PlayingGame { get {return this.playingGame;} set {this.playingGame = value;} }

        private void InitVariables()
        {
            this.end = false;
        }
        public Game()
        {
            InitVariables();
        }

        public void Run()
        {
             Console.WriteLine("Game Start");
            while (this.end == false)
            {
                GUI.Title();
                //GUI.AnyButton();
                MainMenu();
            }
            Console.WriteLine("Game Over");
        }

        public void MainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("[1] Continue");
            Console.WriteLine("[2] New Game");
            Console.WriteLine("[3] Load Game");
            Console.WriteLine("[4] Settings");
            Console.WriteLine("[0] Exit Game");
            string userInput = Console.ReadLine();
            switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Playing Game");
                        PlayGame();
                        break;
                    case "2":
                        Console.WriteLine("Starting New Game");
                        PlayGame();
                        break;
                    case "3":
                        Console.WriteLine("Loading Game");
                        break;
                    case "4":
                       Console.WriteLine("Settings");
                        break;
                    case "0":
                        end = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            public void PlayGame()
            {
                GameOpening();
                playingGame = true;
                while (playingGame == true)
                {
                    //Maybe change this to Game something where you look at the menu seperately
                    GameMenu();
                }
            }

            public void GameOpening()
            {
                Console.WriteLine("Welcome to Heroes of The Imperial Federation");
                GUI.AnyButton();
                Console.WriteLine("You are an adventurer travelling to The Village of Dale within The Valley of Dale.");
                GUI.AnyButton();
            }
            public void GameMenu()
            {
                GUI.Title();
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
                        CombatTest();
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
            public void ViewCharacterSheet()
            {
                Console.WriteLine("---- Character Sheet ----");
                Console.WriteLine(hero.ToString());
                GUI.AnyButton();
            }
            public void CombatTest()
            {
                Character goblin = new Character("Goblin", "A Goblin", 1);
                goblin.hp = 5;
                Combat newCombat = new Combat();
                newCombat.RunCombat(hero, goblin);
            }
        }
}