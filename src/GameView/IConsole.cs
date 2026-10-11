using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src.GameView
{
    public interface IConsole
    {
        void Clear();
        void WriteLine(string text);
        ConsoleKeyInfo ReadKey();
    }
}
