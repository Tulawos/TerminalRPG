using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src
{
    public class Monsters : Character
    {

        public void AddDamage(int damageReceived) => Damage += damageReceived;

        public void ResetDamage() => Damage = 0;

        public int GetHP() => Hp - Damage;
    }
}