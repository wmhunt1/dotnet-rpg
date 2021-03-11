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
            goblin.hp = 5;
            goblin.strength = 5;
            goblin.CalculateStats();
            Combat newCombat = new Combat();
            newCombat.RunCombat(hero, goblin);
        }
    }
}