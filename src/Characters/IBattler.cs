using AdventureTest.src.BattleActions;
using AdventureTest.src.Moves;

namespace AdventureTest.src.Characters
{
    public interface IBattler
    {
        public int Initiative { get; }
        public void RollInitiative();
        public void TakeDamage(int damageReceived);
        public int GetCurrentHP();
        public void ResetDamage();        
        public Actions ChooseAction();
    }
}
