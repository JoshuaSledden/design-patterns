using System;
using System.Collections.Generic;
using System.Text;

namespace strategy
{
    public class MagicAttack : IAttacking
    {
        public int Attack(int baseDamage)
        {
            int result = baseDamage * 2;
            Console.WriteLine($"Performing a magic attack: baseDamage({baseDamage}) * 2 = {result}!");
            return result;
        }
    }
}
