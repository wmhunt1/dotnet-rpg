using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Character
    {
        public String Name;
        public int Hp;
        public int MaxHp;
        public int Atk;

        public Character (String charName, int charHp, int charMaxHp, int charAttk)
        {
            Name = charName;
            Hp = charHp;
            MaxHp = charMaxHp;
            Atk = charAttk;
        }
    }
}