using System;
using System.Numerics;
using AdventureTest.src.FileHandler;
using AdventureTest.src.CombatEng;

namespace AdventureTest.src
{
    public class Program
    {
        static void Main()
        {
            LoadGame loadGame = new LoadGame();
            var player = loadGame.LoadPlayer("data\\player\\playerdata.json");
            CombatEngine combat = new CombatEngine(player, loadGame.LoadMonsters("data\\monsters\\monsterdata.json"));
            combat.Combat();

            FileHandler<Player> fileHandler = new FileHandler<Player>();
            fileHandler.Save(player);
        }
    }
}
