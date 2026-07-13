using AdventureTest.src.CombatEng;
using AdventureTest.src.FileHandler;
using AdventureTest.src.Moves;
using Google.GenAI;
using System;
using System.Numerics;

namespace AdventureTest.src
{
    public class Program 
    {
        static void Main()
        {            
            LoadGame loadGame = new();
            SaveGame saveGame = new();

            var player = loadGame.LoadPlayer(
                "C:\\Users\\aleja\\Desktop\\Software Projects\\AdventureTest\\Files\\player.json");
            var monsters = loadGame.LoadMonsters(
                "C:\\Users\\aleja\\Desktop\\Software Projects\\AdventureTest\\Files\\monsters.json");
            var moves = loadGame.LoadMoves(
                "C:\\Users\\aleja\\Desktop\\Software Projects\\AdventureTest\\Files\\moves.json");

            MovesList movesList = new(moves);
            BattleGenerator combat = new(player, monsters);
            combat.GenerateBattle(player);
            saveGame.Save(player);
        }
    }
}