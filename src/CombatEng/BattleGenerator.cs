

namespace AdventureTest.src.CombatEng
{
    public class BattleGenerator
    {
        Player player;
        Dictionary<int, MOB> monsters;
        Random rand = new Random();

        public BattleGenerator(Player player, Dictionary<int, MOB> monsters)
        {
            this.player = player;
            this.monsters = monsters;
        }
        public void GenerateBattle(Player player)
        {
            List<MOB> combatants = GenerateCombatants();
            Battle battle = new Battle(player, combatants);
            battle.BattleStart();
        }
        private List<MOB> GenerateCombatants()
        {
            List<MOB> combatants = new List<MOB>();
            int numCombatants = rand.Next(1, 5); 

            while (numCombatants <= combatants.Count())
            {
                int index = rand.Next(0, monsters.Count());
                combatants.Add(monsters[index]);
            }
            return combatants;
        }
    }
}
