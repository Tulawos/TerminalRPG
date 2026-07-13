using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AdventureTest.src.FileHandler
{
    public class SaveGame
    {
        public void Save(Player player)
        {
            var options = new JsonSerializerOptions();

            options.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize<Player>(player, options);
            File.WriteAllText(
                "C:\\Users\\aleja\\Desktop\\Software Projects\\AdventureTest\\Files\\player_save_file.json", jsonString);
        }
    }
}
