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
            SaveGame saveGame = new SaveGame();
            var player = loadGame.LoadPlayer(
                "C:\\Users\\aleja\\Desktop\\Software Projects\\AdventureTest\\Files\\player.json");
            var monsters = loadGame.LoadMonsters(
                "C:\\Users\\aleja\\Desktop\\Software Projects\\AdventureTest\\Files\\monsters.json");
            Battle combat = new Battle(player, monsters);
            combat.BattleStart();
            saveGame.Save(player);
        }
    }
}