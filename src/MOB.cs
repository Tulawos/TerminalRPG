
using AdventureTest.src.Moves;
using System.Collections.Generic;

namespace AdventureTest.src
{
    public class MOB : Attributes, ICombatant
    {
        public int ID { get; private set; }
        public void TakeDamage(int damageReceived) => Damage += damageReceived;
        public void ResetDamage() => Damage = 0;
        public int GetCurrentHP() => MaxHp - Damage;
        public int RollInitiative() => Dice.Roll(DiceType.D20) + Accuracy;

       

        public void ChooseAction(MOB target)
        {
            Fight(target);
            
        }
        public virtual void Fight(MOB target)
        {
            ChooseMove(target);
            int attackRoll = Dice.Roll(DiceType.D20) + Accuracy;
            if (attackRoll >= target.Defense)
            {
                int damage = Dice.Roll(DamageDie);
                target.TakeDamage(damage);
            }
        }

        private void ChooseMove(MOB target)
        {
            
        }


    }
}