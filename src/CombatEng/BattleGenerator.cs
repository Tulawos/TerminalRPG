

using AdventureTest.src.Characters;

namespace AdventureTest.src.CombatEng
{
    public class BattleGenerator
    {
        protected Player player;
        protected Dictionary<int, Monster> monsters;
        protected Random rand;
        protected int maxCombatants = 2; //based on map location will update when map gets implemented

        public BattleGenerator(Player player, Dictionary<int, Monster> monsters)
        {
            this.player = player;
            this.monsters = monsters;
            this.rand = new Random();
        }

        public void GenerateBattle()
        {
            List<MOB> combatants = GenerateCombatants();
            Battle battle = new Battle(player, combatants);
            battle.BattleStart();
        }
        protected List<MOB> GenerateCombatants()
        {
            List<MOB> combatants = [];
            int numCombatants = rand.Next(0, maxCombatants); 

            while (combatants.Count <= numCombatants)
            {
                int index = rand.Next(0, monsters.Count);
                combatants.Add(monsters[index].Copy());
            }
            return combatants;
        }
    }
}
