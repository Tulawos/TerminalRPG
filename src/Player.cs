using AdventureTest.src.FileHandler;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AdventureTest.src
{
    
    public class Player : ICombatant
    {
        public string Name { get; set; } = "";
        public int Level { get; set; }
        public int MaxHp { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int Accuracy { get; set; }
        public DiceType DamageDie { get; set; }
        public int Xp { get; set; }

        public void AddXP(int xpEarned) => Xp += xpEarned;
        public void UpdateHealth(int damageReceived) => Damage += damageReceived;
        public void ResetDamage() => Damage = 0;
        public int GetCurrentHP() => MaxHp - Damage;
        public int RollInitiative() => Dice.Roll(DiceType.D20) + Accuracy;
        
    }
}
