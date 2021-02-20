using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    class StateMainMenu : State
    {
        protected ArrayList characterList;
        public StateMainMenu(Stack<State> states, ArrayList character_list) 
        : base(states)
        {
           this.characterList = character_list;
        }
        public void ProcessInput(int input)
        {
            switch (input)
            {
                case 0:
                this.end = true;
                break;
                case 1:
                break;
                case 2:
                this.states.Push(new StateCharacterCreator(this.states, this.characterList));
                break;
                 case 3:
                 Console.WriteLine(this.characterList.Count);
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
              Console.Write(GUI.MenuOption(3, "List Characters"));
            Console.Write(GUI.MenuOption(0, "Exit"));
            GUI.GetInput("Input");
            int input = Convert.ToInt32(Console.ReadLine());
            this.ProcessInput(input);
        }
    }
}