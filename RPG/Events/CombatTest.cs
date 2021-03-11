using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class CombatTest
    {
        public void RunCombatTest(Character hero)
        {
            Character goblin = new Character("Goblin", "A Goblin", 1);
            Combat newCombat = new Combat();
            newCombat.RunCombat(hero, goblin);
        }
    }
}