using AdventureTest.src.FileHandler;
using System;
using AdventureTest.src.Moves;
using AdventureTest.src.Characters;

namespace AdventureTest.src
{
    public class GameDatabase
    {
        public Player player;
        public Dictionary<int, Monster> monsters {  get; private set; }

        public GameDatabase(List<string> list) 
        {
            player = LoadGame.LoadPlayer(list[0]);
            monsters = LoadGame.LoadMonsters(list[1]);

            player.SetMoves();

            foreach (var monster in monsters.Values)
            {
                monster.SetMoves();
            }
        }
    }
}
