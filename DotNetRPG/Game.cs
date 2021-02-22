using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    class Game
    {
       private ArrayList characterList;
       //variable
       private bool end;
       public bool End
       {
           get {return this.end;}
           set {this.end = value;}
       }
        private Stack<State> states;
       //private functions
        private void InitVariables()
        {
            this.end = false;
        }
        private void InitCharacterList()
        {
            this.characterList = new ArrayList();
        }
        private void InitStates()
       {
           this.states = new Stack<State>();
             //Console.WriteLine(this.states.GetHashCode();
           //push the first state
            this.states.Push(new StateMainMenu(this.states, this.characterList));
            //this.states.Push(new StateGame(this.states));
       }
       //Constructors and Destructors
       public Game(){
           this.InitVariables();
           this.InitCharacterList();
           this.InitStates();
           this.characterList.Add(new Character("Hero", ""));

           //Console.WriteLine("Hello from the Game Class!");
       }
       public void Run()
       {
           while(this.states.Count > 0)
           {
                 if (this.states.Count > 0)
                 {
                    this.states.Peek().Update();
                    if (this.states.Peek().QuitGame())
                    //not sure if needs these brackets
                    {
                        this.states.Pop();
                    }
                 }
           }
           Console.WriteLine("Ending Game...");
       }
    }
}