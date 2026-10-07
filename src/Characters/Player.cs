using AdventureTest.src.BattleActions;
using AdventureTest.src.Moves;
using AdventureTest.src.GameView;

namespace AdventureTest.src.Characters
{    
    public class Player : MOB
    {
        public InputHandler InputHandler { get; private set; }

        public Player(CharacterStats stats) : base(stats)
        {
            InputHandler = new InputHandler();
        }
        public void AddXP(int xpEarned) => Stats.AddXp(xpEarned); 
        
        public override Actions ChooseAction()
        {
            return new Fight(this);
        } 

        public void SetMoves()
        {
            // Implement logic to set the player's moves based on their level or other criteria
            // For now, we can add some default moves or implement a simple selection mechanism
            ActiveMoves.Add(new Slash());
        }
    }
}
