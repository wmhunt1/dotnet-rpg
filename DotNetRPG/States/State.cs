using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    class State
    {
        Stack<State> states;
        public State(Stack<State> states)
        {
            this.states = states;
            //Console.WriteLine(this.states.GetHashCode());
            //this.states.Push(new State(this.states));
        }
    }
}