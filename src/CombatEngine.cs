using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src
{
    internal class CombatEngine
    {
        Fighter[] turnOrder;

        public void Battle(Player player, Monsters monsters)
        {
            TurnOrder(player, monsters);

            while (player.Hp > 0 && monsters.Hp > 0)
            {
                BattleRound(player, monsters);
            }
        }

        private void TurnOrder(Player player, Monsters monsters)
        {
            Fighter[] tmpOrder = new Fighter[2];
            int playerInitiative = Dice.Roll(DiceType.D20) + player.Accuracy;
            int monsterInitiative = Dice.Roll(DiceType.D20) + monsters.Accuracy;

            if(playerInitiative >= monsterInitiative)
            {
                tmpOrder[0] = player;
                tmpOrder[1] = monsters;
            }
            else
            {
                tmpOrder[0] = monsters;
                tmpOrder[1] = player;
            }
            turnOrder = tmpOrder;
        }

        private void BattleRound(Player player, Monsters monsters)
        {
            for (int i = 0; i < turnOrder.Length; i++)
            {
                if (turnOrder[i] is Player)
                {
                    Attack(player, monsters);
                }
                else
                {
                    Attack(turnOrder[i], player);
                }
            }
        }

        private void Attack(Fighter attacker , Fighter defender)
        {
            int attackRoll = Dice.Roll(DiceType.D20) + attacker.Accuracy;

            if (attackRoll >= defender.Defense)
            {
                
            }
        }
    }
}
