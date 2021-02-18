using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    class Game
    {
       //variable
       private bool end;
       public bool End
       {
           get {return this.end;}
           set {this.end = value;}
       }
        private Stack<State> states;
       //private functions
       private void InitStates()
       {
           this.states = new Stack<State>();
             //Console.WriteLine(this.states.GetHashCode();
           //push the first state
           this.states.Push(new State(this.states));
       }
        private void InitVariables()
        {
            this.end = false;
        }
       //Constructors and Destructors
       public Game(){
           this.InitVariables();
           this.InitStates();
           //Console.WriteLine("Hello from the Game Class!");
       }
       public void Run()
       {
           while(this.end == false)
           {
                 Console.WriteLine("Write a number: ");
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
           Console.WriteLine("Ending Game...");
       }
    }
}