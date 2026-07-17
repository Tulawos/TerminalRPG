using AdventureTest.src.Moves;
using System.Reflection;
using System.Xml.Linq;

namespace AdventureTest.src.GameView
{
    public class FightView : CombatView
    {
        public void AvailableMovePrint(Player player)
        {
            speedHandler.TextManipulatorWithSpace("Available moves:", mediumSpeed);
            for (int i = 0; i < player.activeMoves.Count; i++)
                speedHandler.TextManipulatorWithSpace(i + 1 + ". " + player.activeMoves[i].Name, fastSpeed);
        }

        public int ChooseMoveHandler(Player player)
        {
            speedHandler.TextManipulatorWithSpace("\nChoose a move: ", mediumSpeed);
            int response = InputVerifier(player, player.activeMoves.Count);

            Console.WriteLine();
            speedHandler.TextManipulatorWithSpace("You have chosen " + player.activeMoves[response - 1].Name + ".\n", mediumSpeed);
            Console.ReadKey();
            return response;
        }

        public void AvailabeTargetsPrint(Player player, List<Monster> targets)
        {
            Console.Clear();
            BattleStatus(player, targets);

            List<Monster> copyOfMonsters = RemoveDeadMonsters(targets);
            speedHandler.TextManipulatorWithSpace("Available targets: ", mediumSpeed);
            for (int i = 0; i < copyOfMonsters.Count; i++)
            {
                speedHandler.TextManipulatorWithSpace(i + 1 + ". " + copyOfMonsters[i].Name, fastSpeed);
            }
        }

        public List<Monster> ChooseTargetsHandler(Player player, List<Monster> targets, Move move)
        {
            List<Monster> chosenTargets = new List<Monster>();
            List<Monster> copyOfMonsters = RemoveDeadMonsters(targets);
            speedHandler.TextManipulatorWithSpace("\nChoose a target: ", mediumSpeed);

            while (chosenTargets.Count < move.NumberOfTargets && chosenTargets.Count < copyOfMonsters.Count)
            {
                int response = InputVerifier(player, copyOfMonsters.Count);
                chosenTargets.Add(copyOfMonsters[response - 1]);
            }

            Console.WriteLine();
            speedHandler.TextManipulatorWithSpace("You have chosen to attack: ", mediumSpeed);
            foreach (Monster mon in chosenTargets) speedHandler.TextManipulatorWithSpace(mon.Name, fastSpeed);
            Console.WriteLine();

            return chosenTargets;
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
                speedHandler.TextManipulatorWithSpace("Your attack missed " + target.Name + ".", mediumSpeed);
            else
                speedHandler.TextManipulatorWithSpace(attacker.Name + "'s attack missed.", mediumSpeed); 
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

        private int InputVerifier(Player player, int limit)
        {
            int response = player.inputHandler.GetIntInput();

            while (!player.inputHandler.InputWithinRange(response, limit))
            {
                speedHandler.TextManipulatorWithSpace("Incorrect input. Please choose an input within range", mediumSpeed);
                response = player.inputHandler.GetIntInput();
            }
            return response;
        }

        private List<Monster> RemoveDeadMonsters(List<Monster> monsters)
        {
            List<Monster> copyOfMonsters = new List<Monster>(monsters);
            copyOfMonsters.RemoveAll(monster => monster.GetCurrentHP() <= 0);
            return copyOfMonsters;
        }
    }
}
