using System;
using System.Numerics;

namespace AdventureTest.src
{
    public class Program
    {
        static void Main()
        {
            FileHandler<Player> fileHandler = new FileHandler<Player>();
            Player player = fileHandler.Load("C:\\Users\\aleja\\Desktop\\C# Projects\\AdventureTest\\PlayerData.json");
            Console.WriteLine(player.Name);

            FileHandler<Monsters> enemy = new FileHandler<Monsters>();
            Monsters orc = enemy.Load("C:\\Users\\aleja\\Desktop\\C# Projects\\AdventureTest\\mobdata.json");
            Console.WriteLine(orc.Name);
        }
    }
}
