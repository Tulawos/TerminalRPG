
using AdventureTest.src.Characters;

namespace AdventureTest.src.Moves
{
    public class Slash : Move, ISingleTarget
    {
        public Slash()
        {
            Name = "Slash";
            Element = ElementType.Normal;
            NumberOfTargets = 1;
            MinDamage = 5;
            MaxDamage = 10;
        }

        public MOB ChooseSingleTarget(MOB source, List<MOB> targets)
        {
            int choice = 0;
            if (source is Player)
            {
                Player player = (Player)source;
                choice = player.InputHandler.GetIntInput() - 1;
            }
            return targets[choice];
        }

        public override Dictionary<MOB, int> ExecuteMove(MOB source, List<MOB> targets)
        {
            Dictionary<MOB, int> damageDealt = new Dictionary<MOB, int>();

            MOB target = targets[0];
            int damage = new Random().Next(MinDamage, MaxDamage + 1);
            target.TakeDamage(damage);
            damageDealt[target] = damage;
            return damageDealt;
        }
    }
}
