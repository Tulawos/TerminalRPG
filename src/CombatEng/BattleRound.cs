using AdventureTest.src.BattleActions;
using AdventureTest.src.Characters;
using AdventureTest.src.GameView;

namespace AdventureTest.src.CombatEng
{
    public class BattleRound
    {
        Battle Battle;
        Queue<IBattler> combatants;
        public IConsole view { get; private set; }
        public CombatText text { get; private set; }

        public BattleRound(Battle battle, Queue<IBattler> combatants, IConsole view)
        {
            this.Battle = battle;
            this.combatants = combatants;
            this.view = view;
            this.text = new CombatText();
        }        

        public void Round()
        {
            while (RoundCondition())
            {
                view.WriteLine(text.WriteBattleStatus(Battle.player, Battle.monsters));
                var combatant = combatants.Dequeue();

                if (combatant is Player)
                    Turn();
                else if (combatant.GetCurrentHP() > 0)
                {
                    Monster monster = (Monster)combatant;
                    Turn(monster);
                }  
            }
            view.Clear();
            RemoveDeadMonsters();
        }

        private void Turn()
        {
            Actions action = Battle.player.ChooseAction();
            action.DoAction(Battle.monsters, Battle.player);
        }

        private void Turn(Monster monster)
        {
            Fight fight = new Fight(monster);
            fight.DoAction(Battle.monsters, Battle.player);
        }

        private bool RoundCondition()
        {
            if (combatants.Count == 0 || Battle.player.GetCurrentHP() == 0) 
                return false;
            else
                return true;
        }

        private void RemoveDeadMonsters()
        {
            Battle.monsters.RemoveAll(m => m.GetCurrentHP() <= 0);
        }
    }
}
