
using AdventureTest.src.Characters;

namespace AdventureTest.src.GameView
{
    public class View : IConsole
    {
        protected TextSpeedHandler speedHandler;
        protected int mediumSpeed = 25;
        protected int fastSpeed = 25;
        protected int instant = 0;

        public View()
        {
            speedHandler = new TextSpeedHandler();
        }

        public void Clear() => Console.Clear();
        public void WriteLine(string text) => Console.WriteLine(text);
        public ConsoleKeyInfo ReadKey() => Console.ReadKey(true);

    }
}