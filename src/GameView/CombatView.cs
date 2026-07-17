
namespace AdventureTest.src.GameView
{
    public class CombatView
    {
        protected TextSpeedHandler speedHandler;
        protected int mediumSpeed = 25;
        protected int fastSpeed = 25;
        protected int instant = 0;

        public CombatView()
        {
            speedHandler = new TextSpeedHandler();
        }

        public void BattleStatus(Player player, List<Monster> monsters)
        {
            speedHandler.TextManipulatorWithSpace(player.Name + " HP: " 
                + player.GetCurrentHP() + "/" + player.MaxHp, instant);
            for (int i = 0; i < monsters.Count; i++)
            {
                if (i % 2 == 0) Console.WriteLine();
                speedHandler.TextManipulatorNoSpace(monsters[i].Name + " HP: " 
                    + monsters[i].GetCurrentHP() + "/" + monsters[i].MaxHp + "\t" , instant);
            }
            Console.WriteLine("\n");
        }
    }
}