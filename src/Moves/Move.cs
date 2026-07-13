using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src.Moves
{
    public class Move : IMove
    {
        public string Name { get; set; } = "";
        public ElementType Element { get; set; }
        public int Damage { get; set; }
        public int CriticalChance { get; set; }

        public void Execute()
        {
            //TODO
        }
    }
}
