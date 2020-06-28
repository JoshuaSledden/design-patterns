using System;
using System.Collections.Generic;
using System.Text;

namespace strategy
{
    public class RangeAttack : IAttacking
    {
        public int Attack(int baseDamage)
        {
            int result = baseDamage * 3;
            Console.WriteLine($"Performing a range attack: baseDamage({baseDamage}) * 3 = {result}!");
            return result;
        }
    }
}
