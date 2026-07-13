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
        public int MaxHp { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int Accuracy { get; set; }
        public DiceType DamageDie { get; set; }
        public int Xp { get; set; }

    }
}
