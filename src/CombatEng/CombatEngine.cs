namespace AdventureTest.src.CombatEng
{
    public class CombatEngine
    {
        Player player;
        List<Monsters> monsters;

        public CombatEngine(Player player, List<Monsters> monsters)
        {
            this.player = player;
            this.monsters = monsters;
        }

        public void Battle()
        {
            int round = 0;

            while (player.Hp > 0 && monsters.Count() > 0 && round < 10)
            {
                Queue<ICombatant> turnOrder = SetTurnOrder();
                round++;

                BattleRound battleRound = new BattleRound(player, monsters, turnOrder);
                battleRound.Round();
            }
        }

        private Queue<ICombatant> SetTurnOrder()
        {

            var characters = SetInitiatives();

            Queue<ICombatant> turnOrder = new Queue<ICombatant>();
            foreach(var character in characters)
            {
                turnOrder.Enqueue(character);
            }

            return turnOrder;
        }

        private List<AdventureTest.ICombatant> SetInitiatives()
        {
            List<AdventureTest.ICombatant> characterLists = new List<AdventureTest.ICombatant>();

            player.SetInitiative();
            characterLists.Add(player);

            foreach (var monster in monsters)
            {
                monster.SetInitiative();
                characterLists.Add(monster);
            }

            var sortedList = characterLists.OrderByDescending(c => c.Initiative).ToList();

            return sortedList;
        }
    }
}