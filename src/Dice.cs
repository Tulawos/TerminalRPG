using System;

namespace AdventureTest.src
{
    public class Dice
    {
        private static readonly Random _random = new Random();
        public static int Roll(DiceType die)
        {
            if (die == DiceType.D0)
            {
                return 0;
            }
            
            return _random.Next(1, (int)die + 1);
        }
  
    }

    public enum DiceType
    {
        D0 = 0,
        D4 = 4,
        D6 = 6,
        D8 = 8,
        D10 = 10,
        D12 = 12,
        D20 = 20
    }
}
