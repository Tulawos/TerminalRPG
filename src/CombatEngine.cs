using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src
{
    internal class CombatEngine
    {
        public CombatEngine() { }

        public void Battle(Player player, Monsters monsters)
        {

            while(player.Hp > 0 && monsters.Hp > 0)
            {
                Fighter[] turnOrder = TurnOrder(player, monsters);
            }
        }

        private Fighter[] TurnOrder(Player player, Monsters monsters)
        {
            Fighter[] turnOrder = new Fighter[2];
            Dice.Roll(DiceType.D20) + player.Accuracy;
            return turnOrder;
        }
    }
}
