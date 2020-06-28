using System;
using System.Collections.Generic;
using System.Text;

namespace strategy
{
    public class MeleeAttack : IAttacking
    {
        public int Attack(int baseDamage)
        {
            int result = baseDamage + 100;
            Console.WriteLine($"Performing a melee attack: baseDamage({baseDamage}) + 100 = {result}!");
            return result;
        }
    }
}
