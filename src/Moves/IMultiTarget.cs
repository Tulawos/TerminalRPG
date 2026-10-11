using AdventureTest.src.Characters;

namespace AdventureTest.src.Moves
{
    internal interface IMultiTarget
    {
        public List<MOB> ChooseMultipleTargets(MOB source, List<MOB> targets);
    }
}
