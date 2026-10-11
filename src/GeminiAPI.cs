
using Google.GenAI;

namespace AdventureTest.src
{
   

    internal class GeminiAPI
    {
        
        public static async Task main(string prompt)
        {
            var model = "gemini-3-flash-preview";
            var client = new Client();
            var response = await client.Models.GenerateContentAsync(model, prompt);
            Console.WriteLine(response.Text);
            Console.WriteLine();
        }
    }
}
