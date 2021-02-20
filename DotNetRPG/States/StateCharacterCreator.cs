using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    class StateCharacterCreator : State
    {
         //variables
         protected ArrayList characterList;
         //private functions 

        private void CreateCharacter()
        {
            String name ="";
            GUI.GetInput("Input Character Name");
            name = Console.ReadLine();
            String description = "";
            GUI.GetInput("Input character description");
            description = Console.ReadLine();
            this.characterList.Add(new Character(name, description));
            GUI.Announcement("Character Created");
        }  
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
                    this.CreateCharacter();
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
            GUI.MenuTitle("Character Creator");
            GUI.MenuOption(1, "New Character");
            GUI.MenuOption(2, "Edit Character");
            GUI.MenuOption(3, "Delete Character");
            GUI.MenuOption(0, "Exit Character Creator");
            int input = GUI.GetInputInt("Input");
            this.ProcessInput(input);
        }
    }
}