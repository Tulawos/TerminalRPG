using System;
using System.Numerics;

namespace AdventureTest.src
{
    public class Program
    {
        static void Main()
        {
            FileHandler<Player> playerFile = new FileHandler<Player>();
            FileHandler<Monsters> monsterFile = new FileHandler<Monsters>();

            Player player = playerFile.Load("C:\\Users\\aleja\\Desktop\\C# Projects\\AdventureTest\\playerdata.json");
            Monsters monster = monsterFile.Load("C:\\Users\\aleja\\Desktop\\C# Projects\\AdventureTest\\monsterdata.json");

            List<Monsters> monsters = new List<Monsters>();
            monsters.Add(monster);

            Console.WriteLine("Player Name: " + player.Name + "Player HP: " + player.Hp);

            CombatEngine combat = new CombatEngine(player, monsters);
            combat.Combat();
        }
    }
}
