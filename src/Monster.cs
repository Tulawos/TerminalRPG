
namespace AdventureTest.src
{
    public class Monster : MOB, IMonster
    {
        public int Id { get; set ; }

       

        public Monster GetMonstersByID(int id)
        {
            return this;
        }
    }
}
