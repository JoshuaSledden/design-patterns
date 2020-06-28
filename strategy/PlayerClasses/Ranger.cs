using System;
using System.Collections.Generic;
using System.Text;

namespace strategy
{
    public class Ranger : Player
    {
        public Ranger() : base("Ranger", new RangeAttack())
        {
        }
    }
}
