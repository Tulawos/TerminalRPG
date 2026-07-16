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
            List<string> list = new List<string>();
            list.Add("C:\\Users\\aleja\\Desktop\\Software Projects\\TerminalRPG\\Files\\player.json"); //player
            list.Add("C:\\Users\\aleja\\Desktop\\Software Projects\\TerminalRPG\\Files\\monsters.json"); //monsters
            list.Add("C:\\Users\\aleja\\Desktop\\Software Projects\\TerminalRPG\\Files\\Moves.json"); //moves

            GameDatabase gameDatabase = new(list);       
            
            BattleGenerator combat = new(gameDatabase.player, gameDatabase.monsters);
            combat.GenerateBattle();
            SaveGame.Save(gameDatabase.player);
        }
    }
}