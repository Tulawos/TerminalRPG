using AdventureTest.src.FileHandler;
using System;
using AdventureTest.src.Moves;

namespace AdventureTest.src
{
    public class GameDatabase
    {
        public Player player;
        public Dictionary<int, Monster> monsters {  get; private set; }
        public MovesList movesList { get; private set; }

        public GameDatabase(List<string> list) 
        {
            player = LoadGame.LoadPlayer(list[0]);
            monsters = LoadGame.LoadMonsters(list[1]);
            movesList = new(LoadGame.LoadMoves(list[2]));

            player.SetMoves(movesList);

            foreach (var monster in monsters.Values)
            {
                monster.SetMoves(movesList);
            }
        }
    }
}
