

namespace AdventureTest.src.CombatEng
{
    public class BattleGenerator
    {
        Player player;
        Dictionary<int, MOB> monsters;
        Random rand;

        public BattleGenerator(Player player, Dictionary<int, MOB> monsters)
        {
            this.player = player;
            this.monsters = monsters;
            this.rand = new();
        }
        public void GenerateBattle(Player player)
        {
            List<MOB> combatants = GenerateCombatants();
            Battle battle = new(player, combatants);
            battle.BattleStart();
        }
        private List<MOB> GenerateCombatants()
        {
            List<MOB> combatants = [];
            int numCombatants = rand.Next(1, 5); 

            while (numCombatants <= combatants.Count)
            {
                int index = rand.Next(0, monsters.Count);
                combatants.Add(monsters[index]);
            }
            return combatants;
        }
    }
}
