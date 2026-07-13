using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src.CombatEng
{
    internal class Turn
    {
        public void Attack(Player player, List<Monsters> monsters)
        {
            int attackRoll = Dice.Roll(DiceType.D20) + player.Accuracy;

            if (attackRoll >= monsters[0].Defense)
            {

            }
        }

        public void Attack(Monsters monster, Player player, List<Monsters> monsters)
        {
            int attackRoll = Dice.Roll(DiceType.D20) + monster.Accuracy;

            if (attackRoll >= player.Defense)
            {

            }
        }
    }
}
