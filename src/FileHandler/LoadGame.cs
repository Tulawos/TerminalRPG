
namespace AdventureTest.src.FileHandler
{
    public class LoadGame
    {
        public Player LoadPlayer(string fileName)
        {
            FileHandler<Player> playerFile = new FileHandler<Player>();
            return playerFile.Load(fileName);
        }

        public List<Monsters> LoadMonsters(string fileName)
        {
            List<Monsters> monsters = new List<Monsters>();

            FileHandler<List<Monsters>> monsterFile = new FileHandler<List<Monsters>>();
            return monsterFile.Load(fileName);
        }  
    }
}
