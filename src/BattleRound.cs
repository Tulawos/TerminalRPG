using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src
{
    public class BattleRound
    {
        Player player;
        List<Monsters> monsters;
        Queue<Character> combatants;

        public BattleRound(Player player, List<Monsters> monsters, Queue<Character> combatants)
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
                Console.WriteLine(combatant.Name + " takes their turn!");
            }
        }

        private void Attack(Character attacker, Character defender)
        {
            int attackRoll = Dice.Roll(DiceType.D20) + attacker.Accuracy;

            if (attackRoll >= defender.Defense)
            {

            }
        }
    }
}
