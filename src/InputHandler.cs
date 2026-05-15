using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src
{
    internal class InputHandler
    {
        public static int GetInput()
        {
            string response = Console.ReadLine();
            bool success = int.TryParse(response, out int input);

            if (success) return input;
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return GetInput();
            }
        }
    }
}
