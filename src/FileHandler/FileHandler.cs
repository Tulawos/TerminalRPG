using System.Text.Json;
using System.Text.Json.Serialization;

namespace AdventureTest.src.FileHandler
{
    public class FileHandler<T>
    {
        public T Load(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException($"File not found: {fileName}");

            try
            {
                var jsonFile = File.ReadAllText(fileName);
                var options = new JsonSerializerOptions();

                options.PropertyNameCaseInsensitive = true;
                options.Converters.Add(new JsonStringEnumConverter());

                var result = JsonSerializer.Deserialize<T>(jsonFile, options);

                if (result == null) throw new JsonException($"File '{fileName}' deserialized to null.");

                return result;
            }
            catch (JsonException ex)
            {
                throw new Exception($"JSON syntax error in file '{fileName}': {ex.Message}", ex);
            }
            catch (IOException ex)
            {
                throw new Exception($"I/O error reading file '{fileName}': {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load and deserialize file: {fileName}", ex);
            }
        }
    }
}
