using AdventureTest.src.Moves;

namespace AdventureTest.src
{
    public class Util
    {
        public static Dictionary<string, Move> ConvertListToMap(List<Move> moves)
        {
            Dictionary<string, Move> moveMap = [];
            foreach (var move in moves)
            {
                moveMap[move.Name] = move;
            }
            return moveMap;
        }

        public static Dictionary<int, MOB> ConvertListToMap(List<MOB> mobs)
        {
            Dictionary<int, MOB> mobMap = [];
            foreach (var mob in mobs)
            {
                mobMap[mob.ID] = mob;
            }
            return mobMap;
        }
    }
}

