using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src
{
    public abstract class Character
    {
        public string Name { get; set; } = "";
        public int Level { get; set; }
        public int Hp { get; set; }
        public int Defense { get; set; }
        public int Accuracy { get; set; }
        public DiceType DamageDie { get; set; }
        public int Xp { get; set; }
        public int Damage { get; set; } = 0;
        public int Initiative = 0;
        
        public DiceType SetDamageDie(int damageDie)
        {
            if (damageDie == 0)
                return DiceType.D0;
            else if (damageDie == 4)
                return DiceType.D4;
            else if (damageDie == 6)
                return DiceType.D6;
            else if (damageDie == 8)
                return DiceType.D8;
            else if (damageDie == 10)
                return DiceType.D10;
            else if (damageDie == 12)
                return DiceType.D12;
            else if (damageDie == 20)
                return DiceType.D20;
            else
                throw new ArgumentException("Invalid damage die type");
        }

        public void SetInitiative() => Initiative = Dice.Roll(DiceType.D20) + Accuracy;
        
    }
}
