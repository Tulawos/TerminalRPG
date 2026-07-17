using AdventureTest.src.BattleActions;
using AdventureTest.src.Moves;
using AdventureTest.src.GameView;

namespace AdventureTest.src
{    
    public class Player : MOB
    {
        public InputHandler inputHandler { get; private set; } = new();

        public Player(string name, int level, int maxHp, int damage, int defense, int accuracy, DiceType damageDie, int xp) 
            :base(name, level, maxHp, damage, defense, accuracy, damageDie, xp)
        {
            
        }
        public void AddXP(int xpEarned) => Xp += xpEarned; 
        
        public override Actions ChooseAction()
        {
            return new Fight(this);
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
