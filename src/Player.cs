using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AdventureTest.src
{
    public class Player : Monsters
    {
        
        public void AddXP(int xpEarned) => Xp += xpEarned;
    }
}
