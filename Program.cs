using System;
using System.Numerics;

namespace AdventureTest
{
    public class Program
    {
        static void Main()
        {
            ReadJson reader = new ReadJson();
            Player player = reader.LoadPlayer();
            Console.WriteLine($"Player Name: {player.Name}");
        }
    }
}
