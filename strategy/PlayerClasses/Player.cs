using System;
using System.Collections.Generic;
using System.Text;

namespace strategy
{
    public abstract class Player
    {
        private IAttacking _attacking;
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        protected Player(string name, IAttacking attacking)
        {
            Console.WriteLine($"New player created of class: {name}");

            _name = name;
            _attacking = attacking;
        }

        public int Attack(int baseDamage)
        {
            return _attacking.Attack(baseDamage);
        }
    }
}
