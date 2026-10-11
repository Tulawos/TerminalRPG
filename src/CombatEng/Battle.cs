using AdventureTest.src.Characters;
using AdventureTest.src.GameView;

namespace AdventureTest.src.CombatEng
{
    public class Battle
    {
        public Player player { get; private set; }
        public List<MOB> monsters { get; private set; }
        

        public Battle(Player player, List<MOB> monsters)
        {
            this.player = player;
            this.monsters = monsters;
        }

        public void BattleStart()
        {            
            while (player.GetCurrentHP() > 0 && monsters.Count > 0)
            {
                Queue<IBattler> turnOrder = SetTurnOrder();
                BattleRound battleRound = new BattleRound(this, turnOrder, new View());
                battleRound.Round();
            }
        }

        protected Queue<IBattler> SetTurnOrder()
        {
            Queue<IBattler> turnOrder = new Queue<IBattler>();
            var characters = SetInitiatives();            
            foreach(var character in characters) 
                turnOrder.Enqueue(character);

            return turnOrder;
        }

        private List<IBattler> SetInitiatives()
        {
            List<IBattler> characterLists = new List<IBattler>();

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