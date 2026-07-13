namespace AdventureTest.src.CombatEng
{
    public class Battle
    {
        readonly Player player;
        readonly List<MOB> monsters;

        public Battle(Player player, List<MOB> monsters)
        {
            this.player = player;
            this.monsters = monsters;
        }

        public void BattleStart()//remove round
        {
            int round = 0;

            while (player.MaxHp > 0 && monsters.Count > 0 && round < 10)
            {
                Queue<ICombatant> turnOrder = SetTurnOrder();
                round++;

                BattleRound battleRound = new(player, monsters, turnOrder);
                battleRound.Round();
            }
        }

        private Queue<ICombatant> SetTurnOrder()
        {
            Queue<ICombatant> turnOrder = new();
            var characters = SetInitiatives();
            
            foreach(var character in characters) turnOrder.Enqueue(character);

            return turnOrder;
        }

        private List<ICombatant> SetInitiatives()
        {
            List<ICombatant> characterLists = [];

            player.RollInitiative();
            characterLists.Add(player);

            foreach (var monster in monsters)
            {
                monster.RollInitiative();
                characterLists.Add(monster);
            }

            var sortedList = characterLists.OrderByDescending(c => c.Initiative).ToList();

            return sortedList;
        }
        
    }
}