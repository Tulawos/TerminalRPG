

namespace AdventureTest.src.CombatEng
{
    public class BattleGenerator
    {
        readonly Player player;
        readonly Dictionary<int, Monster> monsters;
        readonly Random rand;

        public BattleGenerator(Player player, Dictionary<int, Monster> monsters)
        {
            this.player = player;
            this.monsters = monsters;
            this.rand = new();
        }
        public void GenerateBattle()
        {
            List<Monster> combatants = GenerateCombatants();
            Battle battle = new(player, combatants);
            battle.BattleStart();
        }
        private List<Monster> GenerateCombatants()
        {
            List<Monster> combatants = [];
            int numCombatants = rand.Next(1, 4); 

            while (combatants.Count <= numCombatants)
            {
                int index = rand.Next(0, monsters.Count);
                combatants.Add(monsters[index]);
            }
            return combatants;
        }
    }
}
