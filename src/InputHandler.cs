using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src
{
    public class InputHandler
    {
        public string GetInput()
        {
            string response = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine("Input cannot be empty. Please enter a valid input:");
                response = Console.ReadLine();
            }

            return response;
        }

        public int GetIntInput()
        {
            int result;
            string response = GetInput();

            while(!int.TryParse(response, out result))
            {
                Console.WriteLine(response + " is not a valid input. Please enter a valid input.");
                response = GetInput();
            }
            return result;
        }

        public bool InputWithinRange(int input, int size) => (input < 1 || input > size) ? false : true;
        
    }
}
