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
        
    }
}
