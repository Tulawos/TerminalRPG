using AdventureTest.src.Moves;
using static Google.Apis.Requests.BatchRequest;
namespace AdventureTest.src.Dialog
{
    public class CombatText
    {
        private TextSpeedHandler speedHandler;
        private int mediumSpeed = 50;
        private int fastSpeed = 25;

        public CombatText()
        {
            speedHandler = new TextSpeedHandler();
        }

        public void AvailableMovePrint(MOB player)
        {

            speedHandler.TextSpeed("Available moves:", mediumSpeed);
            for (int i = 0; i < player.activeMoves.Count; i++) 
            {
                speedHandler.TextSpeed(i + 1 + ". " + player.activeMoves[i].Name, fastSpeed);
            }
        }

        public int ChooseMoveHandler(Player player)
        {
            speedHandler.TextSpeed("\nChoose a move: ", mediumSpeed);
            int response = InputVerifier(player, player.activeMoves.Count);

            Console.WriteLine();
            speedHandler.TextSpeed("You have chosen " + player.activeMoves[response - 1].Name + ".\n", mediumSpeed);

            return response;
        }

        public void AvailabeTargetsPrint(List<Monster> targets)
        {
            speedHandler.TextSpeed("Available targets: ", mediumSpeed);
            for(int i = 0; i < targets.Count; i++)
            {
                speedHandler.TextSpeed(i + 1 + " " + targets[i].Name, fastSpeed);
            }
        }

        public List<Monster> ChooseTargetsHandler(Player player, List<Monster> targets, Move move)
        {
            List<Monster> chosenTargets = new List<Monster>();
            speedHandler.TextSpeed("\nChoose a target: ", mediumSpeed);

            while (chosenTargets.Count < move.NumberOfTargets || chosenTargets.Count == targets.Count)
            {
                int response = InputVerifier(player, targets.Count);
                chosenTargets.Add(targets[response - 1]);
            }

            Console.WriteLine();
            speedHandler.TextSpeed("You have chosen to attack: ", mediumSpeed);
            foreach (Monster mon in chosenTargets) speedHandler.TextSpeed(mon.Name, fastSpeed);
            Console.WriteLine();

            return chosenTargets;
        }

        private int InputVerifier(Player player, int limit)
        {
            int response = player.inputHandler.GetIntInput();

            while (!player.inputHandler.InputWithinRange(response, limit))
            {
                speedHandler.TextSpeed("Incorrect input. Please choose an input within range", mediumSpeed);
                response = player.inputHandler.GetIntInput();
            }
            return response;
        }

        public void AttackHit(string name, int damage)
        {
            speedHandler.TextSpeed("You hit " + name + " for " + damage + " damage.", mediumSpeed);
        }

        public void AttackMissed()
        {
            speedHandler.TextSpeed("Your attack missed.", mediumSpeed);
        }

        public void TargetRemainingHP(Monster target)
        {
            speedHandler.TextSpeed(target.Name + " remaining HP: " + target.GetCurrentHP() + "/" + target.MaxHp + "\n", 50);
        }
    }
}
