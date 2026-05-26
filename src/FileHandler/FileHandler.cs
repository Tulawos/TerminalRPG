using System.Text.Json;

namespace AdventureTest.src.FileHandler
{
    public class FileHandler<T>
    {
        public T Load(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException($"File not found: {fileName}");

            var jsonFile = File.ReadAllText(fileName);
            var options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            return JsonSerializer.Deserialize<T>(jsonFile, options);
        }

        public void Save(Player player)
        {
            var options = new JsonSerializerOptions();

            options.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize<Player>(player, options);
            File.WriteAllText("data\\player\\playerdata.json", jsonString);
        }
    }
}
