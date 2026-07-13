using AdventureTest.src;

namespace AdventureTest
{
    public interface ICombatant
    {
        public int RollInitiative();
        public void TakeDamage(int damageReceived);
        public int GetCurrentHP();
        public void ResetDamage();
        //public void Fight(MOB target);
    }
}
