using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Game
    {
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
            while (this.end == false)
            {
                Console.WriteLine("Game Start");
                end = true;
            }
            Console.WriteLine("Game Over");
        }
    }
}