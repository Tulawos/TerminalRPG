namespace AdventureTest.src.Moves
{
    public class MovesList
    {
        public Dictionary<string, Move> Moves { get; private set; }
        public MovesList(Dictionary<string, Move> Moves)
        {
            this.Moves = Moves;
        }
        
        public Move GetMoveByName(string name) => Moves[name];

        public List<Move> GetListOfMoves(List<string> moveNames)
        {
            List<Move> list = new List<Move>();
            foreach(var moveName in moveNames)
            {
                list.Add(Moves[moveName]);
            }
            return list;
        }
        
    }
}
