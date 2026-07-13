using AdventureTest.src.Moves;

namespace AdventureTest.src
{
    public class Util
    {
        public Dictionary<string, Move> ConvertListToMap(List<Move> moves)
        {
            Dictionary<string, Move> moveMap = new Dictionary<string, Move>();
            foreach (var move in moves)
            {
                moveMap[move.Name] = move;
            }
            return moveMap;
        }

        public Dictionary<int, MOB> ConvertListToMap(List<MOB> mobs)
        {
            Dictionary<int, MOB> mobMap = new Dictionary<int, MOB>();
            foreach (var mob in mobs)
            {
                mobMap[mob.ID] = mob;
            }
            return mobMap;
        }
    }
}

