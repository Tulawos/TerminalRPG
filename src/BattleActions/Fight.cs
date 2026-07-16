using AdventureTest.src.GameView;
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

        public override void Execute(List<Monster> targets)
        {
            Move move = new();

            if(Attacker is MOB)
            {
                Player player = (Player)Attacker;
                move = ChooseMove(player);
                targets = ChooseTarget(player, targets, move);
                Attack(move, targets);
            }
            else
            {
                Monster monster = (Monster)Attacker;
                move = ChooseMove(monster);
            }
        }        

        private Move ChooseMove(Player player)
        {
            text.AvailableMovePrint(player);
            int response = text.ChooseMoveHandler(player);
            return player.activeMoves[response - 1];
        }

        private Move ChooseMove(Monster monster)
        {
            return new Move();
        }

        private List<Monster> ChooseTarget(Player player, List<Monster> targets, Move move)
        {
            text.AvailabeTargetsPrint(targets);
            List<Monster> results = text.ChooseTargetsHandler(player, targets, move);
            return results;
        }

        private void Attack(Move move, List<Monster> targets)
        {            
            foreach (var target in targets)
            {
                int attackRoll = Dice.Roll(DiceType.D20) + Attacker.Accuracy;
                if (attackRoll >= target.Defense)
                {
                    int damage = Dice.Roll(Attacker.DamageDie + move.Damage);
                    target.TakeDamage(damage);
                    text.AttackHit(target.Name, damage);
                }
                else 
                {
                    text.AttackMissed();
                }
                text.TargetRemainingHP(target);                
            }
        }
    }
}