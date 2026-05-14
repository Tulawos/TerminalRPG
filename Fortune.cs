using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest
{
    public class Fortune
    {
        public string name { get; }
        public int armor { get; }
        public DiceType damageDie { get; }
        public int hitModifier { get; }
        public int hpBonus { get; }
        

        public Fortune(string name, int bonusHP, int armor, int hitModifier)
        {
            this.name = name;
            this.hpBonus = bonusHP;
            this.armor = armor;
            this.hitModifier = hitModifier;
            this.damageDie = DiceType.D0;
        }


        public DiceType SetDamageDie(/*string damageDie*/)
        {
            return DiceType.D4;
        }
    }
}
