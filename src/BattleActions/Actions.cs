using AdventureTest.src.Characters;
using AdventureTest.src.GameView;

namespace AdventureTest.src.BattleActions
{
    public abstract class Actions
    {
        public FightView text = new FightView();
        public abstract void ExecuteAction(List<MOB> targets, MOB player);
    }
}
