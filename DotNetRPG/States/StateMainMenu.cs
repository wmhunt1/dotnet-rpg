using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    class StateMainMenu : State
    {
        public StateMainMenu(Stack<State> states) 
        : base(states)
        {
           
        }
        public void ProcessInput(int input)
        {
            switch (input)
            {
                case -1:
                this.end = true;
                break;
                case 1:
                break;
                case 2:
                this.states.Push(new StateCharacterCreator(this.states));
                break;
                default:
                    break;
            }
        }
        override public void Update()
        {
            Console.Write(GUI.MenuTitle("Main Menu"));
            Console.Write(GUI.MenuOption(1, "New Game"));
            Console.Write(GUI.MenuOption(2, "Character Creator"));
            Console.Write(GUI.MenuOption(-1, "Exit"));
            GUI.GetInput("Input");
            int input = Convert.ToInt32(Console.ReadLine());
            this.ProcessInput(input);
        }
    }
}