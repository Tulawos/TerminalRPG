using AdventureTest.src.Moves;

namespace AdventureTest.src.Characters
{
    public class Monster : MOB, IMonster
    {
        public int Id { get; set ; }

        public Monster(CharacterStats stats, int id) : base(stats)
        {
            Id = id;
        }

        public Monster GetMonstersByID(int id) => this;

        public Monster Copy() => new Monster(this.Stats, Id);
        

        public void SetMoves()
        {
            ActiveMoves.Add(new Slash());
        }
    }
}
