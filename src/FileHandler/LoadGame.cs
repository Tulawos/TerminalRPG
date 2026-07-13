using AdventureTest.src.Moves;

namespace AdventureTest.src.FileHandler
{
    public class LoadGame
    {
        public Player LoadPlayer(string fileName)
        {
            FileHandler<Player> playerFile = new();
            return playerFile.Load(fileName);
        }

        public Dictionary<int, MOB> LoadMonsters(string fileName)
        {
            FileHandler<List<MOB>> monsterFile = new();
            Dictionary<int, MOB> monsterDictionary = Util.ConvertListToMap(monsterFile.Load(fileName));
            return monsterDictionary;
        }
        public Dictionary<string, Move> LoadMoves(string fileName)
        {
            FileHandler<List<Move>> moveFile = new();
            Dictionary<string, Move> moveDictionary = Util.ConvertListToMap(moveFile.Load(fileName));
            return moveDictionary;
        }
    }
}
