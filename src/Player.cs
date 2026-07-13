
namespace AdventureTest.src
{
    
    public class Player : MOB
    {
        public void AddXP(int xpEarned) => Xp += xpEarned;
        public override void Fight(MOB target)
        {
            int attackRoll = Dice.Roll(DiceType.D20) + Accuracy;
            if (attackRoll >= target.Defense)
            {
                int damage = Dice.Roll(DamageDie);
                target.TakeDamage(damage);
            }
        }
        public void ChooseAction(List<MOB> monsters)
        {




        }
    }
}
