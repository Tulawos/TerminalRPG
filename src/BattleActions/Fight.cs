namespace AdventureTest.src.BattleActions
{
    public class Fight : Actions
    {
        private MOB Attacker;
        private List<MOB> Defenders;
        public Fight(MOB attacker, List<MOB> defender)
        {
            this.Attacker = attacker;
            this.Defenders = defender;
        }

        public void Execute(List<MOB> Defenders)
        {
            int attackRoll = Dice.Roll(DiceType.D20) + Attacker.Accuracy;
            foreach (var defender in Defenders)
            {
                if (attackRoll >= defender.Defense)
                {
                    int damage = Dice.Roll(Attacker.DamageDie);
                    defender.TakeDamage(damage);
                }
            }
        }
    }
}