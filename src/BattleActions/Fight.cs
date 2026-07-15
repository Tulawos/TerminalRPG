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

            if(Attacker is Player)
            {
                Player player = (Player)Attacker;
                move = player.ChooseMove();
                targets = player.ChooseTarget(targets, move);
                Attack(move, targets);
            }
            else
            {
                Attacker.ChooseMove();
            }
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
                    Console.WriteLine("You hit " + target + " for " + damage + " damage.");
                }
                else 
                {
                    Console.WriteLine("Your attack missed.");
                }

                Console.WriteLine(target.Name + " remaining HP: " + target.GetCurrentHP() + "/" + target.MaxHp);                
            }
        }
    }
}