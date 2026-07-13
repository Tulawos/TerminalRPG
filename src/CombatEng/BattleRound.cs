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
        List<Monsters> monsters;
        Queue<ICombatant> combatants;
        public int RoundNumber { get; set; }

        public BattleRound(Player player, List<Monsters> monsters, Queue<ICombatant> combatants)
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
                    Turn playerTurn = new Turn(player, monsters);
                }
                else
                {
                    Monsters monster = (Monsters)combatant;
                    Turn playerTurn = new Turn(monster, player, monsters);
                }
            }
        }
    }
}
