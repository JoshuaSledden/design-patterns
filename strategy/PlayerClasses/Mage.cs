using System;
using System.Collections.Generic;
using System.Text;

namespace strategy
{
    public class Mage : Player
    {
        public Mage() : base("Mage", new MagicAttack())
        {
        }
    }
}
