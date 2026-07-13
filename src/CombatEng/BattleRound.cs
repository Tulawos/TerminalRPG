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
            Turn turn = new Turn();
            while (combatants.Count() != 0)
            {
                var combatant = combatants.Dequeue();

                if (combatant is Player)
                {
                    turn.Attack(player, monsters);
                }
                else
                {
                    
                    Monsters monster = (Monsters)combatant;
                    turn.Attack(monster, player, monsters);
                }
                RoundNumber++;
            }
        }
    }
}
