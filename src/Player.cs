using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AdventureTest.src
{
    public class Player : Fighter
    {
        public void AddXP(int xpEarned) => Xp += xpEarned;
    }
}
