using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    class StateCharacterCreator : State
    {
         public StateCharacterCreator(Stack<State> states) 
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
                default:
                    break;
            }
        }
          override public void Update()
        {
            Console.Write(GUI.MenuTitle("Character Creator"));
            Console.Write(GUI.MenuOption(0, "New Character"));
            Console.Write(GUI.MenuOption(1, "Edit Character"));
            Console.Write(GUI.MenuOption(2, "Delete Character"));
            Console.Write(GUI.MenuOption(-1, "Exit"));
            GUI.GetInput("Input");
            int input = Convert.ToInt32(Console.ReadLine());
            this.ProcessInput(input);
        }
    }
}