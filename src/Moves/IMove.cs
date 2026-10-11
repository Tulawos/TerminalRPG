using AdventureTest.src.Characters;

namespace AdventureTest.src.Moves
{
    internal interface IMove
    {
        public Dictionary<MOB, int> ExecuteMove(MOB source, List<MOB> targets);
    }
}
