using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Game
    {
        Character hero = new Character("Hero", 10, 10, 1);
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
                Console.WriteLine("[1] Character Sheet");
                Console.WriteLine("[2] Combat Test");
                Console.WriteLine("[0] Main Menu");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Viewing Character Sheet");
                        break;
                    case "2":
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
                Console.WriteLine("${hero.Name}");
                GUI.AnyButton();
            }
            public void Combat(Character char1, Character char2)
            {
                Console.WriteLine($"{char1.Name} is in combat with {char2.Name}");
                while (char1.Hp > 0 && char2.Hp > 0)
                {
                    Console.WriteLine($"{char1.Name}: {char1.Hp} VS {char2.Name}: {char2.Hp}");
                    Console.WriteLine($"{char1.Name} attacks");
                    char2.Hp -= char1.Atk;
                    Console.WriteLine($"{char2.Name} attacks");
                    char1.Hp -= char2.Atk;
                    GUI.AnyButton();
                }
                if (char1.Hp > 0)
                {
                    Console.WriteLine($"{char1.Name} wins");
                }
                else
                {
                    Console.WriteLine($"{char1.Name} loses");
                }
            }
            public void CombatTest()
            {
                Character goblin = new Character("Goblin", 5, 5, 1);
                Combat(hero, goblin);
            }
        }
}