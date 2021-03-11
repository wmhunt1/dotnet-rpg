using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{

    public class MainMenu
    {
        private bool endMenu;
        //private bool playingGame;
        public bool EndMenu { get {return this.endMenu;} set {this.endMenu = value;} }
        public void DisplayMainMenu()
        {
           this.endMenu = false;
           while (endMenu == false)
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
                        StartGame playGame = new StartGame();
                        playGame.PlayGame();
                        break;
                    case "2":
                        Console.WriteLine("Starting New Game");
                        StartGame newGame = new StartGame();
                        newGame.PlayGame();
                        break;
                    case "3":
                        Console.WriteLine("Loading Game");
                        break;
                    case "4":
                        Console.WriteLine("Settings");
                        break;
                    case "0":
                        endMenu = true;
                        break;
                        default:
                        Console.WriteLine("Invalid input");
                        break;
                }
           }
           
        }
       
    }
}