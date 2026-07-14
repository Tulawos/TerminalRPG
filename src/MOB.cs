
using AdventureTest.src.Moves;
using System.Collections.Generic;

namespace AdventureTest.src
{
    public class MOB : Attributes, ICombatant
    {
        public int ID { get; private set; }
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

        public virtual void ChooseAction(MOB target)
        {
            Fight(target);
            
        }
        public virtual void Fight(MOB target)
        {
            ChooseMove();
            int attackRoll = Dice.Roll(DiceType.D20) + Accuracy;
            if (attackRoll >= target.Defense)
            {
                int damage = Dice.Roll(DamageDie);
                target.TakeDamage(damage);
            }
        }

        private void ChooseMove()
        {
            
        }


    }
}