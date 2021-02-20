using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    class StateGame : State
    {
        public StateGame(Stack<State> states) 
        : base(states)
        {
            //Console.WriteLine("Hello from the Game State.");
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
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write(GUI.MenuTitle("Game State"));
            Console.Write(GUI.MenuOption(0, "Create Character"));
            Console.Write(GUI.MenuOption(-1, "Exit"));
            GUI.GetInput("Input");
            int input = Convert.ToInt32(Console.ReadLine());
            this.ProcessInput(input);
        }
    }
}