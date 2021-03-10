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
                GUI.Title("------------------------------ Heroes of The Imperial Federation -------------------------------");
                MainMenu newMenu = new MainMenu();
                newMenu.DisplayMainMenu();
            }
            Console.WriteLine("Game Over");
        }

        }
}