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
         override public void Update()
        {
            Console.WriteLine("Write a number in the Game State: ");
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