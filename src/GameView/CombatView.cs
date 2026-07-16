
namespace AdventureTest.src.GameView
{
    public class CombatView
    {
        protected TextSpeedHandler speedHandler;
        protected int mediumSpeed = 50;
        protected int fastSpeed = 25;

        public CombatView()
        {
            speedHandler = new TextSpeedHandler();
        }
    }
}