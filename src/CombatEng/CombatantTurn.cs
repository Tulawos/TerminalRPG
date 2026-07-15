using AdventureTest.src.BattleActions;

namespace AdventureTest.src.CombatEng
{
    internal class CombatantTurn
    {
        public void Turn(Player player, List<Monster> monsters)
        {
            Actions action = player.ChooseAction();
            
            action.Execute(monsters);
        }

        public void Turn(Monster monster, Player player, List<Monster> monsters)
        {
            int attackRoll = Dice.Roll(DiceType.D20) + monster.Accuracy;

            if (attackRoll >= player.Defense)
            {

            }
        }
    }
}
