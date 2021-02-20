using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    class State
    {
        protected Stack<State> states;
        protected bool end = false;
        public State(Stack<State> states)
        {
            this.states = states;
            //Console.WriteLine(this.states.GetHashCode());
            //this.states.Push(new State(this.states));
        }
        public bool QuitGame()
        {
            return this.end;
        }
        virtual public void Update()
        {

        }
        
    }
}
