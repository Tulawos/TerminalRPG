using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src.CombatEng
{
    internal class CombatantTurn
    {
        public void Turn(Player player, List<MOB> monsters)
        {
            player.ChooseAction(monsters);
        }

        public void Turn(MOB monster, Player player, List<MOB> monsters)
        {
            int attackRoll = Dice.Roll(DiceType.D20) + monster.Accuracy;

            if (attackRoll >= player.Defense)
            {

            }
        }
    }
}
