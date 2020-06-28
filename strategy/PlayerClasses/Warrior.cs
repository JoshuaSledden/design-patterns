using System;
using System.Collections.Generic;
using System.Text;

namespace strategy
{
    public class Warrior : Player
    {
        public Warrior() : base("Warrior", new MeleeAttack())
        {
        }
    }
}
