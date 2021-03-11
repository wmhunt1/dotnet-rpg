using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class CombatTest
    {
        public void RunCombatTest()
        {
            //need to import character
            Character hero = new Character("Hero", "Your PC", 1);
            Character goblin = new Character("Goblin", "A Goblin", 1);
            goblin.hp = 5;
            Combat newCombat = new Combat();
            newCombat.RunCombat(hero, goblin);
        }
    }
}