using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    class StateMainMenu : State
    {
        protected ArrayList characterList;
        protected Character activeCharacter;
        public StateMainMenu(Stack<State> states, ArrayList character_list) 
        : base(states)
        {
           this.characterList = character_list;
           this.activeCharacter = null;
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
            //want to switch to load game etc eventually
            if (this.activeCharacter != null)
            {
                Console.WriteLine("Active Character: " + this.activeCharacter.Name() + "\n");
            }
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
            //While the active character variable is null, one cannot start the game.
            if (this.activeCharacter == null)
            {
                GUI.Announcement("No active character selected! Please select one before starting the game.");
            }
            else //start game
            {
                this.states.Push(new StateGame(this.states, this.activeCharacter));
            }
        }
        public void SelectCharacter()
        {
            //print all chars to select
            for (int i  = 0; i < this.characterList.Count; i++ )
            {
                Console.WriteLine(i + ": " + characterList[i].ToString());
            }
            int choice = GUI.GetInputInt("Character Selection");
            try 
            {
                this.activeCharacter = (Character)this.characterList[choice];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (this.activeCharacter != null)
            {
                GUI.Announcement($"The character {this.activeCharacter.Name()} is selected");
            }
        }
    }
}