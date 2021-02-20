using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    class StateCharacterCreator : State
    {
         protected ArrayList characterList;
         public StateCharacterCreator(Stack<State> states, ArrayList character_list) 
        : base(states)
        {
           this.characterList = character_list;
        }
          public void ProcessInput(int input)
        {
            switch (input)
            {
                case 1:
                    this.characterList.Add(new Character("Hero"));
                    this.characterList.Add(new Character("Bob"));
                    this.characterList.Add(new Character("Sven"));
                    Console.Write(GUI.Announcement("Character Created"));
                break;
                case 0:
                this.end = true;
                break;
                default:
                    break;
            }
        }
          override public void Update()
        {
            Console.Write(GUI.MenuTitle("Character Creator"));
            Console.Write(GUI.MenuOption(1, "New Character"));
            Console.Write(GUI.MenuOption(2, "Edit Character"));
            Console.Write(GUI.MenuOption(3, "Delete Character"));
            Console.Write(GUI.MenuOption(0, "Exit"));
            GUI.GetInput("Input");
            int input = Convert.ToInt32(Console.ReadLine());
            this.ProcessInput(input);
        }
    }
}