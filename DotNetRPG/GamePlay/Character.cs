using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    class Character
    {
        //Core 
        private String name = "";
        private int level = 0;
        private int attributePoints = 3;
        private int exp = 0;
        private int expMax = 100;
        //Attributes (will change these)
        private int vitality = 1;
        private int strength = 1;
        private int dexterity = 1;
        private int agility = 1;
        private int intelligence = 1;

        //Stats
        private int hp = 0;
        private int hpMax = 0;
        private int damage = 0;
        private int damageMax = 0;
        private int accuracy = 0;
        private int defense = 0;

        //General
        int gold = 100;
    
        private void CalculateExp()
        {
            this.expMax = level * 100;
        }
        private void CalculateStats()
        {
            this.hp = this.vitality*10;
            this.damageMax = this.strength + 2;
            this.damage = this.strength;
            this.accuracy = this.dexterity * 2;
            this.defense = this.agility * 2;

        }
        public Character(String name)
        {
            this.CalculateStats();
            this.name = name;
        }
        public override String ToString()
        {
            return this.name;
        }
    }
}
