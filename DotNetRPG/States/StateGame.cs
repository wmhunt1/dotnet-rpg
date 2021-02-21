using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    class StateGame : State
    {
        protected Character character;
        public StateGame(Stack<State> states, Character activeCharacter) 
        : base(states)
        {
            //Console.WriteLine("Hello from the Game State.");
             this.character = activeCharacter;
        }
         public void ProcessInput(int input)
        {
            switch (input)
            {
                case 0:
                    this.end = true;
                break;
                case 1:
                    Console.WriteLine(this.character.ToString());
                break;
                default:
                    break;
            }
        }
         override public void Update()
        {
            GUI.MenuTitle("Game State");
            GUI.MenuOption(1, "Character Stats");
            GUI.MenuOption(0, "Exit");
            int input = GUI.GetInputInt("Input");
            this.ProcessInput(input);
        }
    }
}