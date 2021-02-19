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
            //Console.WriteLine("Hello from the Main Menu.");
            //had to remove this
            //states.Push(new StateGame(states));
        }
         override public void Update()
        {
            Console.Write(GUI.MenuTitle("Main Menu"));
            Console.Write(GUI.MenuOption(0, "Create Character"));
            Console.Write(GUI.MenuOption(-1, "Exit"));
            Console.WriteLine("Write a number in the Main menu: ");
            int number = Convert.ToInt32(Console.ReadLine());
           
            if (number < 0)
            {
                this.end = true;
            }
            else
            {
                  Console.WriteLine("You inputed: " + number);
            }
        }
    }
}