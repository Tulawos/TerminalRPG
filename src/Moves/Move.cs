
namespace AdventureTest.src.Moves
{
    public class Move : IMove
    {
        public string Name { get; set; } = "";
        public ElementType Element { get; set; }      
        public int NumberOfTargets { get; set; }
        public int Damage { get; set; }
        public void Execute()
        {
            //TODO
        }
    }
}
