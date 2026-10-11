using AdventureTest.src.CombatEng;
using AdventureTest.src.FileHandler;

namespace AdventureTest.src
{
    public class Program 
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add(args[0]); //player
            list.Add(args[1]); //monsters

            GameDatabase gameDatabase = new(list);       
            
            BattleGenerator combat = new BattleGenerator(gameDatabase.player, gameDatabase.monsters);
            combat.GenerateBattle();
            SaveGame.Save(gameDatabase.player);
        }
    }
}