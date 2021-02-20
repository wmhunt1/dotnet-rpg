using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    class StateGame : State
    {
        protected ArrayList characterList;
        public StateGame(Stack<State> states, ArrayList character_list) 
        : base(states)
        {
            //Console.WriteLine("Hello from the Game State.");
             this.characterList = character_list;
        }
         public void ProcessInput(int input)
        {
            switch (input)
            {
                case 0:
                this.end = true;
                break;
                default:
                    break;
            }
        }
         override public void Update()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write(GUI.MenuTitle("Game State"));
            Console.Write(GUI.MenuOption(1, "Create Character"));
            Console.Write(GUI.MenuOption(0, "Exit"));
            GUI.GetInput("Input");
            int input = Convert.ToInt32(Console.ReadLine());
            this.ProcessInput(input);
        }
    }
}