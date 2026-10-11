
using AdventureTest.src.MovesList;

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

        public Monster Copy()
        {
            CharacterStats newStats = new CharacterStats(this.Stats.Name, this.Stats.Level, 
                this.Stats.MaxHp, this.Stats.Damage, this.Stats.Defense, this.Stats.Accuracy, this.Stats.Xp);
            return new Monster(newStats, Id);
        }        

        public void SetMoves()
        {
            ActiveMoves.Add(new Slash());
        }
    }
}
