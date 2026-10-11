
using AdventureTest.src.Characters;

namespace AdventureTest.src.Moves
{
    public interface IAllTargets
    {
        public List<MOB> ChooseAllTargets(MOB source, List<MOB> targets);
    }
}
