using System;
using System.Threading.Tasks;
using Google.GenAI;
using Google.GenAI.Types;

namespace AdventureTest.src
{
   

    internal class GeminiAPI
    {
        
        public static async Task main(string prompt)
        {
            var model = "gemini-3-flash-preview";
            // The client gets the API key from the environment variable `GOOGLE_API_KEY`.
            //string key = System.Environment.GetEnvironmentVariable("GOOGLE_API_KEY");
            var client = new Client();
            var response = await client.Models.GenerateContentAsync(model, prompt);
            Console.WriteLine(response.Text);
        }
    }
}
