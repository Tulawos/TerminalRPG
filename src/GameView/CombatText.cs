using AdventureTest.src.Characters;
using AdventureTest.src.Moves;
using System.Reflection;
using System.Xml.Linq;
using static Google.Apis.Requests.BatchRequest;

namespace AdventureTest.src.GameView
{
    public class CombatText 
    {
        public string WriteBattleStatus(Player player, List<MOB> monsters)
        {
            string display = WriteBattleStatusPlayerInformation(player);
            display += WriteBattleStatusMonsterInformation(monsters);
            return display;
        }

        private string WriteBattleStatusPlayerInformation(Player player)
        {
            return player.Stats.Name + " HP: " + player.GetCurrentHP() + "/" + player.Stats.MaxHp + "\n";
        }

        private string WriteBattleStatusMonsterInformation(List<MOB> monsters)
        {
            string display = "";
            for (int i = 0; i < monsters.Count; i++)
            {
                if (i % 2 == 0) display += "\n";
                display += monsters[i].Stats.Name + " HP: " + monsters[i].GetCurrentHP() + "/" + monsters[i].Stats.MaxHp + "\t";
            }            
            return display + "\n";
        }
        public string WriteAvailableMoves(Player player)
        {
            string display = "Available moves:\n";
            for (int i = 0; i < player.ActiveMoves.Count; i++)
            {
                display += (i + 1) + ". " + player.ActiveMoves[i].Name + "\n";
            }
            return display;
        }

        public string WriteChooseMove(Player player)
        {
            string display = "\nChoose a move: \n";
            return display;
        }

        public string WriteChosenMove(Move move)
        {
            string display = "You have chosen " + move.Name + ".\n";
            return display;
        }

        public string WriteChooseTarget(Player player, List<MOB> targets)
        {
            string display = WriteBattleStatus(player, targets);
            display += "Available targets: \n";
            for (int i = 0; i < targets.Count; i++)
            {
                display += (i + 1) + ". " + targets[i].Stats.Name + "\n";
            }
            return display;
        }

        public string WriteChosenTargets(Player player, List<MOB> targets)
        {
            string display = "\n You have chosen to attack: ";
            foreach (Monster mon in targets)
            {
                display += mon.Stats.Name + " ";
            }
            return display;
        }

        public string WriteAttackHit(MOB attacker, string name, int damage)
        {
            string display = "";
            if (attacker is Player)
                display = "You hit " + name + " for " + damage + " damage.";
            else
                display = name + " hits you for " + damage + ".";
            return display;
        }

        public string WriteAttackMissed(MOB attacker, MOB target)
        {
            string display = "";
            if (attacker is Player)
                display = "Your attack missed " + target.Stats.Name + ".";
            else
                display = attacker.Stats.Name + "'s attack missed.";
            return display;
        }

        public string WriteMonsterAttacking(string monsterName, string moveName)
        {
            return monsterName + " attacks you with " + moveName + ".";
        }

        public string WritePlayerDeadMessage(Player player)
        {
            return "You have died...";
        }
    }
}
