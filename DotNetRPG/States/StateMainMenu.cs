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
    }
}