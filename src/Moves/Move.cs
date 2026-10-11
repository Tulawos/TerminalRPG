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
        public string Name { get; protected set; } = "";
        public ElementType Element { get; protected set; }
        public int NumberOfTargets { get; protected set; }
        public int MinDamage { get; protected set; }
        public int MaxDamage { get; protected set; }
        
        public abstract Dictionary<MOB, int> ExecuteMove(MOB source, List<MOB> targets);
    }
}
