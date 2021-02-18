using System;

namespace DotNetRPG
{
    class Game
    {
       //variable
       bool end;

       //private functions
        private void InitVariables()
        {
            this.end = false;
        }
       //Constructors and Destructors
       public Game(){
           this.InitVariables();
           Console.WriteLine("Hello from the Game Class!");
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