using AdventureTest.src.BattleActions;
using AdventureTest.src.Moves;

namespace AdventureTest.src
{
    public interface ICombatant
    {
        public int Initiative { get; }
        public int RollInitiative();
        public void TakeDamage(int damageReceived);
        public int GetCurrentHP();
        public void ResetDamage();        
        public Actions ChooseAction();
    }
}
