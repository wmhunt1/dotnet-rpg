using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Game
    {
        Character hero = new Character("Hero", 10, 10);
        Character goblin = new Character("Goblin", 5, 5);
        private bool end;
        public bool End { get {return this.end;} set {this.end = value;} }

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
                GUI.AnyButton();
                MainMenu();
            }
            Console.WriteLine("Game Over");
        }

        public void MainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("[1] Play Game");
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
                Combat(hero, goblin);
            }
            public void Combat(Character char1, Character char2)
            {
                Console.WriteLine($"{char1.Name} is in combat with {char2.Name}");
                while (char1.Hp > 0 && char2.Hp > 0)
                {
                    Console.WriteLine($"{char1.Name}: {char1.Hp} VS {char2.Name}: {char2.Hp}");
                    Console.WriteLine($"{char1.Name} attacks");
                    char2.Hp -= 1;
                    Console.WriteLine($"{char2.Name} attacks");
                    char1.Hp -= 1;
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
        }
}