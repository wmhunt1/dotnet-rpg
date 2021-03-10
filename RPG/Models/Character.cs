using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Character
    {
        //Core 
        public String name = "";
        public String description = "";
        public int level = 0;
        public int exp = 0;
        public int maxExp = 100;
        //Attributes/Abilities
        private int strength = 10;
        private int dexterity = 10;
        private int constitution = 10;
        private int intelligence = 10;
        private int wisdom = 10;
        private int charisma = 10;
        private int luck = 10;
        //Derived Stats
        public int hp = 0;
        public int maxHp = 0;
        public int mp = 0;
        private int maxMp = 0;
        private int stamina = 0;
        private int maxStamina = 0;
        private int attack = 0;
        public int damage = 0;
        //private int maxDamage = 0;
        private int magicAttack = 0;
        //private int magicDamage = 0;
        //defense and armor same stat?
        private int defense = 0;
        //private int armor = 0;
        private int magicDefense = 0; 

        //General
        int gold = 10;

        private void CalculateExp()
        {
            this.maxExp = level * 100;
        }
        private void CalculateStats()
        {
            this.hp = this.constitution*this.level;
            this.maxHp = this.constitution*this.level;
            this.mp = this.intelligence;
            this.maxMp = this.intelligence;
            this.stamina = this.constitution;
            this.maxStamina = this.constitution;
            this.attack = this.dexterity;
            this.damage = this.strength/5;
            this.magicAttack = this.intelligence;
            this.defense = this.dexterity;
            this.magicDefense = this.wisdom;
        }
         private void LevelUP()
        {
            this.level++;
            Console.WriteLine($"{this.name} has leveled up.");
            CalculateExp();
            CalculateStats();
        }

        public void gainXP(int x)
        {
            this.exp += x;
            Console.WriteLine($"{this.name} gained {x} XP");
            if (this.exp >= maxExp)
            {
                LevelUP();
            }
        }
        public Character (String name, String description, int level)
        {
            this.name = name;
            this.description = description;
            this.level = level;
            this.CalculateStats();
        }
         public override String ToString()
        {
            String str = $"Name:\t{this.name}\n" +
            $"Level:\t{this.level}\n" +
            $"Exp:\t{this.exp}/{this.maxExp}\n";
            return str;
        }
       
    }
}