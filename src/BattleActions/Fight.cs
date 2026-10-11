using AdventureTest.src.Characters;
using AdventureTest.src.Moves;
using static Google.Apis.Requests.BatchRequest;

namespace AdventureTest.src.BattleActions
{
    public class Fight : Actions
    {
        private MOB Attacker;        
        
        public Fight(MOB attacker)
        {
            this.Attacker = attacker;
        }

        public override void DoAction(List<MOB> targets, MOB target)
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

        protected Move ChooseMove(Player player)
        {
            Move move;
            view.WriteLine(text.WriteAvailableMoves(player));
            view.WriteLine(text.WriteChooseMove(player));
           
            int response = player.InputHandler.GetIntInput();
            while (response < 1 || response > player.ActiveMoves.Count)
            {
                response = player.InputHandler.GetIntInput();
            }
            
            move = player.ActiveMoves[response - 1];
            view.WriteLine(text.WriteChosenMove(move)); 
            return move;
        }

        private List<MOB> ChooseTarget(Player player, List<MOB> targets, Move move)
        {
            List<MOB> chosenTargets = new List<MOB>();

            if (move is ISingleTarget)
            {
                view.WriteLine(text.WriteChooseTarget(player, targets));
                MOB chosenTarget = ((ISingleTarget)move).ChooseSingleTarget(player, targets);
                chosenTargets.Add(chosenTarget);
                view.WriteLine(text.WriteChosenTargets(player, chosenTargets));
            }
            else if (move is IAllTargets)
            {
                chosenTargets = ((IAllTargets)move).ChooseAllTargets(player, targets);
            }
            else if (move is IMultiTarget)
            {
                //multiple target logic
            }
            return chosenTargets;
        }

        private void DoMove(List<MOB> targets, Move move)
        {
            var damageDealt = move.ExecuteMove(Attacker, targets);
            
            foreach (KeyValuePair <MOB, int> mob in damageDealt)
            {
                view.WriteLine(text.WriteAttackHit(Attacker, mob.Key.Stats.Name, mob.Value));
            }
        }
    }
}