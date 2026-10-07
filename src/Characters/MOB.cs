using AdventureTest.src.BattleActions;
using AdventureTest.src.GameView;
using AdventureTest.src.Moves;

namespace AdventureTest.src.Characters
{
    public class MOB : IBattler
    {
        public int Initiative { get; private set; }
        public List<Move> ActiveMoves { get; private set; }

        public CharacterStats Stats { get; private set; } 

        public MOB() 
        {
            ActiveMoves = new List<Move>();
            Stats = new CharacterStats();
        }
        public MOB(CharacterStats stats)
        {
            Stats = stats;
            ActiveMoves = new List<Move>();
        }

        public void TakeDamage(int damageReceived) => Stats.UpdateHealth(damageReceived);

        public void ResetDamage() => Stats.ResetHealth();
        public int GetCurrentHP() => Stats.MaxHp - Stats.Damage;
        public void RollInitiative() 
        {
            Initiative = Stats.Accuracy;
        }              

        public virtual Actions ChooseAction()
        { 
            return new Fight(this); 
        }
    }
}