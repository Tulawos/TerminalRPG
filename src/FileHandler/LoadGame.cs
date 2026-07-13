using AdventureTest.src.Moves;

namespace AdventureTest.src.FileHandler
{
    public class LoadGame
    {
        Util util = new Util();
        public Player LoadPlayer(string fileName)
        {
            FileHandler<Player> playerFile = new FileHandler<Player>();
            return playerFile.Load(fileName);
        }

        public Dictionary<int, MOB> LoadMonsters(string fileName)
        {
            FileHandler<List<MOB>> monsterFile = new FileHandler<List<MOB>>();
            Dictionary<int, MOB> monsterDictionary = util.ConvertListToMap(monsterFile.Load(fileName));
            return monsterDictionary;
        }
        public Dictionary<string, Move> LoadMoves(string fileName)
        {
            FileHandler<List<Move>> moveFile = new FileHandler<List<Move>>();
            Dictionary<string, Move> moveDictionary = util.ConvertListToMap(moveFile.Load(fileName));
            return moveDictionary;
        }
    }
}
