using System.Text.Json;

namespace AdventureTest.src
{
    public class FileHandler<T>
    {
        public T Load(string fileName)
        {
            var playerJson = File.ReadAllText(fileName);
            var options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            return JsonSerializer.Deserialize<T>(playerJson, options);
        }

        public void Save(T player)
        {
            var options = new JsonSerializerOptions();

            options.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize<T>(player, options);
            File.WriteAllText("C:\\Users\\aleja\\Desktop\\C# Projects\\AdventureTest\\PlayerData.json", jsonString);
        }
    }
}
