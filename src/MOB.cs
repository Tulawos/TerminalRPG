
using AdventureTest.src.BattleActions;
using AdventureTest.src.Moves;
using System.Collections.Generic;

namespace AdventureTest.src
{
    public class MOB : Attributes, ICombatant
    {
        public int Initiative { get; private set; }

        public MOB() { }
        public MOB(string name, int level, int maxHp, int damage, int defense, int accuracy, DiceType damageDie, int xp)
        {
            Name = name;
            Level = level;
            MaxHp = maxHp;
            Damage = damage;
            Defense = defense;
            Accuracy = accuracy;
            DamageDie = damageDie;
            Xp = xp;   
        }

        public void TakeDamage(int damageReceived) => Damage += damageReceived;
        public void ResetDamage() => Damage = 0;
        public int GetCurrentHP() => MaxHp - Damage;
        public int RollInitiative() => Dice.Roll(DiceType.D20) + Accuracy;       

        public virtual Actions ChooseAction()
        { 
            return new Fight(this); 
        }
    }
}