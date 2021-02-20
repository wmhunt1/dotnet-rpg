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
            GUI.MenuTitle("Game State");
            GUI.MenuOption(1, "Create Character");
            GUI.MenuOption(0, "Exit");
            int input = GUI.GetInputInt("Input");
            this.ProcessInput(input);
        }
    }
}