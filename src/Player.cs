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
        public int Hp { get; set; }
        public int Defense { get; set; }
        public int Accuracy { get; set; }
        public DiceType DamageDie { get; set; }
        public int Xp { get; set; }
        public int CurrentHealth { get; set; }
        public int Initiative { get; set; }


        public void SetInitiative() => Initiative = Dice.Roll(DiceType.D20) + Accuracy;
        public void AddXP(int xpEarned) => Xp += xpEarned;
    }
}
