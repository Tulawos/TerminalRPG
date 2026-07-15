using AdventureTest.src.Moves;

namespace AdventureTest.src.FileHandler
{
    public class LoadGame
    {
        public static Player LoadPlayer(string fileName)
        {
            FileHandler<Player> playerFile = new();
            return playerFile.Load(fileName);
        }

        public static Dictionary<int, Monster> LoadMonsters(string fileName)
        {
            FileHandler<List<Monster>> monsterFile = new();
            return Util.ConvertListToMap(monsterFile.Load(fileName));
        }
        public static Dictionary<string, Move> LoadMoves(string fileName)
        {
            FileHandler<List<Move>> moveFile = new();
            List<Move> list = moveFile.Load(fileName);
            Dictionary<string, Move> moveDictionary = Util.ConvertListToMap(moveFile.Load(fileName));
            return moveDictionary;
        }
    }
}
