using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src.CombatEng
{
    internal class Turn
    {
        private ICombatant attacker;
        private ICombatant? defender;
        private List<Monsters> monsters = new List<Monsters>();

        

        public Turn(ICombatant attacker, List<Monsters> monsters)
        {
            this.attacker = attacker;
            this.monsters = monsters;
        }

        public Turn(ICombatant attacker, ICombatant defender, List<Monsters> monsters)
        {
            this.attacker = attacker;
            this.defender = defender;
            this.monsters = monsters;
        }

        private void Attack()
        {
            int attackRoll = Dice.Roll(DiceType.D20) + attacker.Accuracy;

            if (attackRoll >= defender.Defense)
            {

            }
        }
    }
}
