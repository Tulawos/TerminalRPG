using AdventureTest.src.Moves;
using AdventureTest.src.BattleActions;

namespace AdventureTest.src
{    
    public class Player : MOB
    {
        private List<Move> Moves = [];

        public Player(string name, int level, int maxHp, int damage, int defense, int accuracy, DiceType damageDie, int xp) 
            :base(name, level, maxHp, damage, defense, accuracy, damageDie, xp)
        {
            SetMoves();
        }
        public void AddXP(int xpEarned) => Xp += xpEarned; 
        
        public Actions ChooseAction(List<MOB> target)
        {
            
            return new Fight(this, target);
        }        

        public Move ChooseMove()
        {
            Move move = new();


            // Implement logic to choose a move based on player input or strategy
            // For now, we can return a default move or implement a simple selection mechanism
            return new Move(); // Placeholder for actual move selection logic
        }

        private void SetMoves()
        {
            // Implement logic to set the player's moves based on their level or other criteria
            // For now, we can add some default moves or implement a simple selection mechanism

        }
    }
}
