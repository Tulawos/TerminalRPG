
using AdventureTest.src.Moves;

namespace AdventureTest.src
{
    public class Monster : MOB, IMonster
    {
        public int Id { get; set ; }

        public Monster GetMonstersByID(int id)
        {
            return this;
        }

        public void SetMoves(MovesList movesList)
        {
            activeMoves.Add(movesList.GetMoveByName("Slash"));
            activeMoves.Add(movesList.GetMoveByName("Shadow Stab"));
            activeMoves.Add(movesList.GetMoveByName("Holy Smite"));
        }
    }
}
