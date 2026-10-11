
using AdventureTest.src.Characters;

namespace AdventureTest.src.Moves
{
    public class Cleave : Move, IAllTargets
    {
        public Cleave()
        {
            Name = "Cleave";
            Element = ElementType.Normal;
            NumberOfTargets = 4;
            MinDamage = 3;
            MaxDamage = 5;
        }

        public List<MOB> ChooseAllTargets(MOB source, List<MOB> targets)
        {
            return targets;
        }

        public override Dictionary<MOB, int> ExecuteMove(MOB source, List<MOB> targets)
        {
            Dictionary<MOB, int> damageDealt = new Dictionary<MOB, int>();
            int damage = new Random().Next(MinDamage, MaxDamage + 1);

            foreach (MOB target in targets)
            { 
                target.TakeDamage(damage);
                damageDealt[target] = damage;
            }

            return damageDealt;
        }
    }
}
