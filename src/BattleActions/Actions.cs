using AdventureTest.src.Dialog;
using Google.Apis.Http;

namespace AdventureTest.src.BattleActions
{
    public abstract class Actions
    {
        protected CombatText text;
        public abstract void Execute(List<Monster> targets);
    }
}
