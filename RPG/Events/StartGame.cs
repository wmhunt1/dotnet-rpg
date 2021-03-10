using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class StartGame
    {
        public void PlayGame()
        {
            GameOpening newGameOpening = new GameOpening();
            newGameOpening.PlayGameOpening();
            GameMenu newMenu = new GameMenu();
            newMenu.DisplayGameMenu();
        }
    }
}