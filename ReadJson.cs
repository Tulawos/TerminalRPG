using System.Text.Json;

namespace AdventureTest
{
    public class ReadJson
    {
        public static string fileName = "C:\\Users\\aleja\\Desktop\\C# Projects\\AdventureTest\\PlayerData.json";


        public Player LoadPlayer()
        {
           
            string jsonString = File.ReadAllText(fileName);
            var tmpPlayer = JsonSerializer.Deserialize<Player>(jsonString);
            Player player = new Player(tmpPlayer.Name, tmpPlayer.Level, tmpPlayer.Hp, tmpPlayer.Defense, tmpPlayer.Accuracy, tmpPlayer.DamageDie, tmpPlayer.Xp); ;
            return player;
        }
    }
}
