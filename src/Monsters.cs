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
        public int Hp { get; set; }
        public int Defense { get; set; }
        public int Accuracy { get; set; }
        public DiceType DamageDie { get; set; }
        public int Xp { get; set; }
        public int CurrentHealth { get; set; }
        public int Initiative { get; set; }

        public void AddDamage(int damageReceived) => CurrentHealth += damageReceived;

        public void ResetDamage() => CurrentHealth = 0;

        public int GetHP() => Hp - CurrentHealth;

        public void SetInitiative() => Initiative = Dice.Roll(DiceType.D20) + Accuracy;
    }
}