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
    }
}