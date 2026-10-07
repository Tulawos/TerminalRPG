
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
        public override int ExecuteMove(MOB source, MOB target)
        {
            int damage = new Random().Next(MinDamage, MaxDamage + 1);
            target.TakeDamage(damage);
            return damage;
        }

        public MOB ChooseSingleTarget(List<MOB> targets)
        {
            return targets[0];
        }
    }
}
