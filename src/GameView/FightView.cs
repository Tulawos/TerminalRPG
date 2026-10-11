using AdventureTest.src.Characters;
using AdventureTest.src.Moves;
using System.Reflection;
using System.Xml.Linq;
using static Google.Apis.Requests.BatchRequest;

namespace AdventureTest.src.GameView
{
    public class FightView : CombatView
    {
        public void AvailableMovePrint(Player player)
        {
            speedHandler.TextManipulatorWithSpace("Available moves:", mediumSpeed);
            for (int i = 0; i < player.ActiveMoves.Count; i++)
                speedHandler.TextManipulatorWithSpace(i + 1 + ". " + player.ActiveMoves[i].Name, fastSpeed);
        }

        public void PrintChooseMove(Player player)
        {
            speedHandler.TextManipulatorWithSpace("\nChoose a move: ", mediumSpeed);
            Console.WriteLine();
            
        }

        public void PrintChosenMove(Move move)
        {
            speedHandler.TextManipulatorWithSpace("You have chosen " + move.Name + ".\n", mediumSpeed);
            Console.ReadKey();
        }

        public void PrintChooseTarget(Player player, List<MOB> targets)
        {
            Console.Clear();
            BattleStatus(player, targets);
            speedHandler.TextManipulatorWithSpace("Available targets: ", mediumSpeed);
            for (int i = 0; i < targets.Count; i++)
            {
                speedHandler.TextManipulatorWithSpace(i + 1 + ". " + targets[i].Stats.Name, fastSpeed);
            }
            speedHandler.TextManipulatorWithSpace("\nChoose a target: ", mediumSpeed);
        }

        public void ChosenTargets(Player player, List<MOB> targets)
        {
            Console.WriteLine();
            speedHandler.TextManipulatorWithSpace("You have chosen to attack: ", mediumSpeed);
            foreach (Monster mon in targets)
            {
                speedHandler.TextManipulatorWithSpace(mon.Stats.Name, fastSpeed);
            }
            Console.WriteLine();
        }

        public void AttackHit(MOB attacker, string name, int damage)
        {
            if (attacker is Player)
                speedHandler.TextManipulatorWithSpace("You hit " + name + " for " + damage + " damage.", mediumSpeed);
            else
                speedHandler.TextManipulatorWithSpace(name + " hits you for " + damage + ".", mediumSpeed);  
            Console.ReadKey();
        }

        public void AttackMissed(MOB attacker, MOB target)
        {
            if (attacker is Player)
                speedHandler.TextManipulatorWithSpace("Your attack missed " + target.Stats.Name + ".", mediumSpeed);
            else
                speedHandler.TextManipulatorWithSpace(attacker.Stats.Name + "'s attack missed.", mediumSpeed); 
            Console.ReadKey();
        }

        public void MonsterAttacking(string monsterName, string moveName)
        {
            speedHandler.TextManipulatorWithSpace(monsterName + " attacks you with " + moveName + ".", mediumSpeed);
        }

        public void PlayerDeadMessage(Player player)
        {
            if (player.GetCurrentHP() == 0) speedHandler.TextManipulatorWithSpace("You have died...", mediumSpeed);
        }

        public void InvalidInput()
        {
            speedHandler.TextManipulatorWithSpace("Incorrect input. Please choose an input within range", mediumSpeed);
        }
    }
}
