using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src.Characters
{
    internal interface IMonster
    {
        public int Id { get; set; }

        public Monster GetMonstersByID(int id);
        public Monster Copy();
    }
}
