
namespace AdventureTest.src.GameView
{
    public class TextSpeedHandler
    {
        public TextSpeedToken TextSpeed(string input, int delay)
        {
            return new TextSpeedToken(input, delay);
        }
    }

    public class TextSpeedToken : IDisposable
    {
        public TextSpeedToken(string message, int delay)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        public void Dispose()
        {
            Console.WriteLine();
        }
    }
}
