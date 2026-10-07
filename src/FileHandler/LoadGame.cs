using AdventureTest.src.Characters;

namespace AdventureTest.src.FileHandler
{
    public class LoadGame
    {
        public static Player LoadPlayer(string fileName)
        {
            FileHandler<CharacterStats> playerFile = new FileHandler<CharacterStats>();
            CharacterStats characterStats = playerFile.Load(fileName); 
            return new Player(characterStats);
        }

        public static Dictionary<int, Monster> LoadMonsters(string fileName)
        {
            int i = 0;
            FileHandler<List<CharacterStats>> monsterFile = new FileHandler<List<CharacterStats>>();
            List<CharacterStats> monsterStats = monsterFile.Load(fileName);
            Dictionary<int, Monster> mobMap = new Dictionary<int, Monster>();

            foreach (var stat in monsterStats)
            {
                Monster monster = new Monster(stat, i);
                mobMap[i] = monster;
                i++;
            }

            return mobMap;
        }
    }
}
