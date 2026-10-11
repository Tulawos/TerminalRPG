using AdventureTest.src.Characters;
using AdventureTest.src.Moves;

namespace AdventureTest.src.BattleActions
{
    public class Fight : Actions
    {
        private MOB Attacker;        
        
        public Fight(MOB attacker)
        {
            this.Attacker = attacker;
        }

        public override void DoAction(List<MOB> targets, MOB playerTarget)
        {
            Move move;
            List<MOB> chosenTargets;
            if (Attacker is Player)
            {
                Player player = (Player)Attacker;
                move = ChooseMove(player);
                chosenTargets = ChooseTarget(player, targets, move);
                DoMove(chosenTargets, move);
            }
            else
            {
                Monster monster = (Monster)Attacker;
                //implement monster AI logic for choosing move and targets
            }
        }        

        private Move ChooseMove(Player player)
        {
            text.AvailableMovePrint(player);
            int response = text.ChooseMoveHandler(player);
            return player.ActiveMoves[response - 1];
        }

        private List<MOB> ChooseTarget(Player player, List<MOB> targets, Move move)
        {
            List<MOB> chosenTargets = new List<MOB>();
            text.PrintChooseTarget(player, targets);

            if (move is ISingleTarget)
            {
                MOB chosenTarget = ((ISingleTarget)move).ChooseSingleTarget(player, targets);
                chosenTargets.Add(chosenTarget);
            }
            else
            {
                //multiple target logic
            }

            text.ChosenTargets(player, chosenTargets);
            return chosenTargets;
        }

        private void DoMove(List<MOB> targets, Move move)
        {
            var damageDealt = move.ExecuteMove(Attacker, targets);
            
            foreach (KeyValuePair <MOB, int> mob in damageDealt)
            {
                text.AttackHit(Attacker, mob.Key.Stats.Name, mob.Value);
            }
        }
    }
}