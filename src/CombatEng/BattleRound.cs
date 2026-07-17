using AdventureTest.src.BattleActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace AdventureTest.src.CombatEng
{
    public class BattleRound
    {
        Player player;
        List<Monster> monsters;
        Queue<ICombatant> combatants;

        public BattleRound(Player player, List<Monster> monsters, Queue<ICombatant> combatants)
        {
            this.player = player;
            this.monsters = monsters;
            this.combatants = combatants;
        }

        public void Round()
        {
            while (combatants.Count > 0)
            {
                var combatant = combatants.Dequeue();
                if (combatant is Player)
                {
                    Turn();
                }
                else
                {
                    Monster monster = (Monster)combatant;
                    Turn(monster);
                }
            }
        }

        public void Turn()
        {
            Actions action = player.ChooseAction();
            action.Execute(monsters, player);
        }

        public void Turn(Monster monster)
        {
            Fight fight = new Fight(monster);
            fight.Execute(monsters, player);
        }
    }
}
