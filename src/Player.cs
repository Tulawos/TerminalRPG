using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AdventureTest.src
{
    public class Player 
    {
        public string Name { get; set; } = "";
        public int Level { get; set; }
        public int Hp { get; set; }
        public int Defense { get; set; }
        public int Accuracy { get; set; }
        public DiceType DamageDie { get; set; }
        public int Xp { get; private set; }
        public Items ActiveFortune { get; private set; } = new Items("random", 0, 0, 0);

        public void AddXP(int xpEarned) => Xp += xpEarned;

        public int GetArmor()
        {
            if (ActiveFortune != null)
            {
                return Defense + ActiveFortune.armor;
            }
            return Defense;
        }

        public int GetHitModifier()
        {
            if (ActiveFortune != null)
            {
                return Accuracy + ActiveFortune.hitModifier;
            }
            return Accuracy;
        }

        public int GetMaxHP()
        {
            if (ActiveFortune != null)
            {
                return Hp + ActiveFortune.hpBonus;
            }
            return Hp;
        }

        public void SetActiveFortune(Items fortune)
        {
            ActiveFortune = fortune;
        }

        public DiceType SetDamageDie(int damageDie)
        {
            if(damageDie == 0)
                return DiceType.D0;
            else if(damageDie == 4)
                return DiceType.D4;
            else if(damageDie == 6)
                return DiceType.D6;
            else if(damageDie == 8)
                return DiceType.D8;
            else if(damageDie == 10)
                return DiceType.D10;
            else if(damageDie == 12)
                return DiceType.D12;
            else if(damageDie == 20)
                return DiceType.D20;
            else
                throw new ArgumentException("Invalid damage die type");
        }
    }
}
