using AdventureTest.src.BattleActions;
using AdventureTest.src.Moves;
using Google.GenAI.Types;
using System;

namespace AdventureTest.src
{    
    public class Player : MOB
    {
        private InputHandler inputHandler = new();
        private List<string> availableMoves = [];

        public Player(string name, int level, int maxHp, int damage, int defense, int accuracy, DiceType damageDie, int xp) 
            :base(name, level, maxHp, damage, defense, accuracy, damageDie, xp)
        {
            
        }
        public void AddXP(int xpEarned) => Xp += xpEarned; 
        
        public override Actions ChooseAction()
        {
            return new Fight(this);
        } 

        public override Move ChooseMove()
        {
            int i = 1;

            Console.WriteLine("Available moves:");
            foreach (var move in activeMoves)
            {
                Console.WriteLine(i + ". " + move.Name);
                i++;
            }

            Console.Write("\nChoose a move: ");
            int response = inputHandler.GetIntInput();

            while (!inputHandler.InputWithinRange(response, activeMoves.Count))
            {
                Console.WriteLine("Incorrect input. Please choose an input within range");
                response = inputHandler.GetIntInput();
            }

            Console.WriteLine();
            Console.WriteLine("You have chosen " + activeMoves[response - 1].Name + ".\n");
            return activeMoves[response - 1];
        }
        
        public override List<Monster> ChooseTarget(List<Monster> targets, Move move)
        {
            int i = 1;
            List<Monster> chosenTargets = new List<Monster>();

            
            Console.WriteLine("Available targets: ");
            foreach (var target in targets)
            {
                Console.WriteLine(i + " " + target.Name);
                i++;
            }

            Console.Write("\nChoose a target: ");

            while (chosenTargets.Count < move.NumberOfTargets || chosenTargets.Count == targets.Count)
            {
                int response = inputHandler.GetIntInput();

                while (!inputHandler.InputWithinRange(response, targets.Count))
                {
                    Console.WriteLine("Incorrect input. Please choose an input within range");
                    response = inputHandler.GetIntInput();
                }
                chosenTargets.Add(targets[response - 1]);
            }

            Console.WriteLine();
            Console.WriteLine("You have chosen to attack: ");
            foreach (var mon in chosenTargets) Console.WriteLine(mon.Name);
            Console.WriteLine();

            return chosenTargets;
        }

        public void SetMoves(MovesList movesList)
        {
            // Implement logic to set the player's moves based on their level or other criteria
            // For now, we can add some default moves or implement a simple selection mechanism
            activeMoves.Add(movesList.GetMoveByName("Slash"));
            activeMoves.Add(movesList.GetMoveByName("Fireball"));
        }
    }
}
