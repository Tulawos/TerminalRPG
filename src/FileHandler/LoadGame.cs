
namespace AdventureTest.src.FileHandler
{
    public class LoadGame
    {
        public Player LoadPlayer(string fileName)
        {
            FileHandler<Player> playerFile = new FileHandler<Player>();
            return playerFile.Load(fileName);
        }

        public List<MOB> LoadMonsters(string fileName)
        {
            List<MOB> monsters = new List<MOB>();

            FileHandler<List<MOB>> monsterFile = new FileHandler<List<MOB>>();
            return monsterFile.Load(fileName);
        }  
    }
}
