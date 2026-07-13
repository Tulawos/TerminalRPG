using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src
{
    public abstract class Attributes
    {
        public string Name { get; set; } = "";
        public int Level { get; set; }
        public int Hp { get; set; }
        public int Defense { get; set; }
        public int Accuracy { get; set; }
        public DiceType DamageDie { get; set; }
        public int Xp { get; set; }
        public int CurrentHealth { get; set; } 
        public int Initiative { get; set; }

       



        public DiceType SetDamageDie(int damageDie)
        {
            switch(damageDie)
            {
                case 0:
                    return DiceType.D0;
                case 4:
                    return DiceType.D4;
                case 6:
                    return DiceType.D6;
                case 8:
                    return DiceType.D8;
                case 10:
                    return DiceType.D10;
                case 12:
                    return DiceType.D12;
                case 20:
                    return DiceType.D20;
                default:
                    throw new ArgumentException("Invalid damage die type");
            }
        }
    }
}
