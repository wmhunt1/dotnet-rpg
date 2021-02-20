using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    class StateMainMenu : State
    {
        protected ArrayList characterList;
        public StateMainMenu(Stack<State> states, ArrayList character_list) 
        : base(states)
        {
           this.characterList = character_list;
        }
        public void ProcessInput(int input)
        {
            switch (input)
            {
                case 0:
                this.end = true;
                break;
                case 1:
                    this.StartNewGame();
                break;
                case 2:
                this.states.Push(new StateCharacterCreator(this.states, this.characterList));
                break;
                case 3:
                    this.SelectCharacter();
                break;
                default:
                    break;
            }
        }
        override public void Update()
        {
            GUI.MenuTitle("Main Menu");
            GUI.MenuOption(1, "New Game");
            GUI.MenuOption(2, "Character Creator");
            GUI.MenuOption(3, "Select Character");
            GUI.MenuOption(0, "Exit Game");
            int input = GUI.GetInputInt("Input");
            this.ProcessInput(input);
        }
        public void StartNewGame()
        {

        }
        public void SelectCharacter()
        {
            foreach (var character in this.characterList)
            {
                Console.WriteLine(character.ToString());
            }
        }
    }
}