using System;
using System.Text.Json;

namespace AdventureTest
{
    public class Player 
    {
        public string Name { get; }
        public int Level { get; private set; }
        public int Hp { get; private set; }
        public int Defense { get; private set; }
        public int Accuracy { get; private set; }
        public DiceType DamageDie { get; private set; }
        public int Xp { get; private set; }
        public Fortune ActiveFortune = new Fortune("random", 0, 0, 0);//{ get; private set; }

        public Player() { }
        public Player(string name, int level, int hp, int defense, int accuracy, string damageDie, int xp)
        {
            Name = name;
            Level = level;
            Hp = hp;
            Defense = defense;
            Accuracy = accuracy;
            DamageDie = SetDamageDie(damageDie);
            Xp = xp;
        }

        public Player(string name, int level, int hp, int defense, int accuracy, DiceType damageDie, int xp)
        {
            Name = name;
            Level = level;
            Hp = hp;
            Defense = defense;
            Accuracy = accuracy;
            DamageDie = damageDie;
            Xp = xp;
        }

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

        public void SetActiveFortune(Fortune fortune)
        {
            ActiveFortune = fortune;
        }

        public DiceType SetDamageDie(string damageDie)
        {
            if(damageDie == "D0")
                return DiceType.D0;
            else if(damageDie == "D4")
                return DiceType.D4;
            else if(damageDie == "D6")
                return DiceType.D6;
            else if(damageDie == "D8")
                return DiceType.D8;
            else if(damageDie == "D10")
                return DiceType.D10;
            else if(damageDie == "D12")
                return DiceType.D12;
            else if(damageDie == "D20")
                return DiceType.D20;
            else
                throw new ArgumentException("Invalid damage die type");
        }
    }
}
