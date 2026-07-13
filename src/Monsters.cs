using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src
{
    public class Monsters : ICombatant
    {
        public string Name { get; set; } = "";
        public int Level { get; set; }
        public int MaxHp { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int Accuracy { get; set; }
        public DiceType DamageDie { get; set; }
        public int Xp { get; set; }

        public void UpdateHealth(int damageReceived) => Damage += damageReceived;
        public void ResetDamage() => Damage = 0;
        public int GetCurrentHP() => MaxHp - Damage;
        public int RollInitiative() => Dice.Roll(DiceType.D20) + Accuracy;
        
    }
}