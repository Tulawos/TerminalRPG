
namespace AdventureTest.src.GameView
{
    public class TextSpeedHandler
    {
        TextSpeedToken speedToken;
        public TextSpeedHandler() 
        { 
            speedToken = new TextSpeedToken();
        }
        public void TextManipulatorWithSpace(string input, int delay)
        { 
            speedToken.SpeedTextWithLine(input, delay);
        }

        public void TextManipulatorNoSpace(string input, int delay)
        { 
            speedToken.SpeedTextNoLine(input, delay);
        }
    }

    public class TextSpeedToken : IDisposable
    {
        public void SpeedTextWithLine(string message, int delay)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        public void SpeedTextNoLine(string message, int delay)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }

        public void Dispose()
        {
            Console.WriteLine();
        }
    }
}
