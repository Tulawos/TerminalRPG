using AdventureTest.src.BattleActions;
using AdventureTest.src.GameView;

namespace AdventureTest.src.CombatEng
{
    public class BattleRound : Battle
    {        
        Queue<ICombatant> combatants;

        public BattleRound(Player player, List<Monster> monsters, Queue<ICombatant> combatants) : 
            base(player, monsters) 
        { 
            this.combatants = combatants;
            view = new FightView();
        }
        

        public void Round()
        {
            while (RoundCondition())
            {
                view.BattleStatus(player, monsters);
                var combatant = combatants.Dequeue();

                if (combatant is Player)
                    Turn();
                else if (combatant.GetCurrentHP() > 0)
                {
                    Monster monster = (Monster)combatant;
                    Turn(monster);
                }
                Console.Clear();                
            }
        }

        private void Turn()
        {
            Actions action = player.ChooseAction();
            action.Execute(monsters, player);
        }

        private void Turn(Monster monster)
        {
            Fight fight = new Fight(monster);
            fight.Execute(monsters, player);
        }

        private bool RoundCondition()
        {
            if (combatants.Count == 0) return false;
            else if (player.GetCurrentHP() == 0) return false;
            else return true;
        }
    }
}
