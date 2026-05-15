using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src
{
    public class Items
    {
        public string name { get; }
        public int armor { get; }
        public DiceType damageDie { get; }
        public int hitModifier { get; }
        public int hpBonus { get; }
        

        public Items(string name, int bonusHP, int armor, int hitModifier)
        {
            this.name = name;
            hpBonus = bonusHP;
            this.armor = armor;
            this.hitModifier = hitModifier;
            damageDie = DiceType.D0;
        }


        public DiceType SetDamageDie(/*string damageDie*/)
        {
            return DiceType.D4;
        }
    }
}
