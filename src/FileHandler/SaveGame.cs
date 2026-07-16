using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AdventureTest.src.FileHandler
{
    public static class SaveGame
    {
        public static void Save(MOB player)
        {
            var options = new JsonSerializerOptions();

            options.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize<MOB>(player, options);
            File.WriteAllText(
                "C:\\Users\\aleja\\Desktop\\Software Projects\\TerminalRPG\\Files\\player_save_file.json", jsonString);
        }
    }
}
