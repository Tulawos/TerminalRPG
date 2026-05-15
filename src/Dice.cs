using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src
{
    public class Dice
    {
        public static int Roll(DiceType die)
        {
            return new Random().Next(1, (int)die + 1);
            
        }
    }
}
