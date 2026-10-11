using AdventureTest.src.Characters;
using AdventureTest.src.Moves;

namespace AdventureTest.src.MovesList
{
    public class FlurryOfBLows : Move, IMultiTarget
    {
        public FlurryOfBLows()
        {
            Name = "Wild Swings";
            Element = ElementType.Normal;
            NumberOfTargets = 3;
            MinDamage = 6;
            MaxDamage = 8;
        }

        public List<MOB> ChooseMultipleTargets(MOB source, List<MOB> targets)
        {
            // Implementation for choosing multiple targets
            throw new NotImplementedException();
        }

        public override Dictionary<MOB, int> ExecuteMove(MOB source, List<MOB> targets)
        {
            throw new NotImplementedException();
        }
    }
}
