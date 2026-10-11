using AdventureTest.src.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTest.src.Moves
{
    public abstract class Move: IMove
    {
        public string Name { get; set; } = "";
        public ElementType Element { get; set; }
        public int NumberOfTargets { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public abstract Dictionary<MOB, int> ExecuteMove(MOB source, List<MOB> targets);
    }
}
