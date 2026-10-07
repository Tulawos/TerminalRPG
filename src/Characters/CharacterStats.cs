
namespace AdventureTest.src.Characters
{
    public class CharacterStats
    {
        public string Name { get;  set; }
        public int Level { get;  set; }
        public int MaxHp { get;  set; }
        public int Damage { get;  set; }
        public int Defense { get; set; }
        public int Accuracy { get; set; }
        public int Xp { get; set; }

        public CharacterStats()
        {
            Name = "";
        }
        public CharacterStats(string name, int level, int maxHp,
            int damage, int defense, int accuracy, int xp)
        {
            Name = name;
            Level = level;
            MaxHp = maxHp;
            Damage = damage;
            Defense = defense;
            Accuracy = accuracy;
            Xp = xp;
        }

        public void UpdateHealth(int dmg)
        {
            Damage += dmg;
            if (Damage >= MaxHp) Damage = MaxHp;
        }

        public void ResetHealth()
        {
            Damage = 0;
        }

        public void AddXp(int xpEarned) => Xp += xpEarned;
    }
}
