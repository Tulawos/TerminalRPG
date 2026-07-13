using AdventureTest.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest
{
    public interface ICombatant
    {
        string Name { get; set; }
        int Level { get; set; }
        int Hp { get; set; }
        int Defense { get; set; }
        int Accuracy { get; set; }
        public DiceType DamageDie { get; set; }
        int Xp { get; set; }
        int CurrentHealth { get; set; }
        int Initiative { get; set; }

        public void SetInitiative(); 
    }
}
