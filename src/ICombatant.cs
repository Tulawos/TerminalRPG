using AdventureTest.src;

namespace AdventureTest
{
    public interface ICombatant
    {
        string Name { get; set; }
        int Level { get; set; }
        int MaxHp { get; set; }
        int Damage { get; set; }
        int Defense { get; set; }
        int Accuracy { get; set; }
        public DiceType DamageDie { get; set; }
        int Xp { get; set; }

        public int RollInitiative();
        public void UpdateHealth(int damageReceived);
        public int GetCurrentHP();
        public void ResetDamage();
        
    }
}
