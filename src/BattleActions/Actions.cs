using AdventureTest.src.Characters;
using AdventureTest.src.GameView;

namespace AdventureTest.src.BattleActions
{
    public abstract class Actions
    {
        public CombatText text = new CombatText();
        public IConsole view = new View();
        public abstract void DoAction(List<MOB> targets, MOB player);
    }
}
