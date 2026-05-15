using System;
using System.Threading.Tasks;
using Google.GenAI;
using Google.GenAI.Types;

namespace AdventureTest.src
{
   

    internal class GeminiAPI
    {
        private static readonly string GEMINI_API_KEY = System.Environment.GetEnvironmentVariable("gen-lang-client-0806275355");

        public static async Task main()
        {
            // The client gets the API key from the environment variable `GOOGLE_API_KEY`.
            var client = new Client();
            var response = await client.Models.GenerateContentAsync(
              model: "gemini-3-flash-preview", contents: "Explain how AI works in a few words"
            );
            Console.WriteLine(response.Candidates[0].Content.Parts[0].Text);
        }
    }
}
