using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest
{
    public class MOB
    {
        public string Name { get; }
        public int Defense { get; private set; }
        public int Damage { get; private set; }
        public DiceType DamageDie { get; private set; }
        public int Accuracy { get; private set; }
        public int Hp { get; private set; }

        public MOB(string name, int hp, int armor, int hitModifier, DiceType damageDie)
        {
            Name = name;
            Defense = armor;
            Accuracy = hitModifier;
            Hp = hp;
            DamageDie = damageDie;
        }

        //Adds damage to the overall damage done
        public void AddDamage(int damageReceived) => Damage += damageReceived;


        //Makes copy of a MOB class
        public MOB Copy()
        {
            MOB monsterCopy = new MOB(Name, Hp, Defense, Accuracy, DamageDie);
            return monsterCopy;
        }

        public virtual DiceType SetDamageDie()
        {
            return DiceType.D4;
        }

        public virtual void ResetDamage() => Damage = 0;

        public virtual int GetHP() => Hp - Damage;
    }
}