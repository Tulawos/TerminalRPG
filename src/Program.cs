using AdventureTest.src.CombatEng;
using AdventureTest.src.FileHandler;
using Google.GenAI;
using System;
using System.Numerics;

namespace AdventureTest.src
{
    public class Program 
    {
        static void Main()
        {
            LoadGame loadGame = new LoadGame();
            var player = loadGame.LoadPlayer(
                "C:\\Users\\aleja\\Desktop\\Software Projects\\AdventureTest\\Files\\player.json");
            var monsters = loadGame.LoadMonsters(
                "C:\\Users\\aleja\\Desktop\\Software Projects\\AdventureTest\\Files\\monsters.json");
            CombatEngine combat = new CombatEngine(player, monsters);
            combat.Battle();

            FileHandler<Player> fileHandler = new FileHandler<Player>();
            fileHandler.Save(player);
        }
    }
}
