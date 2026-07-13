using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src.CombatEng
{
    public class BattleRound
    {
        Player player;
        List<MOB> monsters;
        Queue<ICombatant> combatants;
        public int RoundNumber { get; set; }

        public BattleRound(Player player, List<MOB> monsters, Queue<ICombatant> combatants)
        {
            this.player = player;
            this.monsters = monsters;
            this.combatants = combatants;
        }

        public void Round()
        {
            CombatantTurn turn = new CombatantTurn();
            while (combatants.Count() != 0)
            {
                var combatant = combatants.Dequeue();
                if (combatant is Player)
                {
                    turn.Turn(player, monsters);
                }
                else
                {
                    
                    MOB monster = (MOB)combatant;
                    turn.Turn(monster, player, monsters);
                }
                RoundNumber++;
            }
        }
    }
}
