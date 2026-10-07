using AdventureTest.src.BattleActions;
using AdventureTest.src.Characters;

namespace AdventureTest.src.CombatEng
{
    public class BattleRound
    {
        Battle Battle;
        Queue<IBattler> combatants;

        public BattleRound(Battle battle, Queue<IBattler> combatants)
        {
            Battle = battle;
            this.combatants = combatants;
        }        

        public void Round()
        {
            while (RoundCondition())
            {
                Battle.view.BattleStatus(Battle.player, Battle.monsters);
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

            RemoveDeadMonsters();
        }

        private void Turn()
        {
            Actions action = Battle.player.ChooseAction();
            action.ExecuteAction(Battle.monsters, Battle.player);
        }

        private void Turn(Monster monster)
        {
            Fight fight = new Fight(monster);
            fight.ExecuteAction(Battle.monsters, Battle.player);
        }

        private bool RoundCondition()
        {
            if (combatants.Count == 0) return false;
            else if (Battle.player.GetCurrentHP() == 0) return false;
            else return true;
        }

        private void RemoveDeadMonsters()
        {
            Battle.monsters.RemoveAll(m => m.GetCurrentHP() <= 0);
        }
    }
}
