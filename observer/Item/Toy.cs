using System;
using System.Collections.Generic;
using System.Text;

namespace observer
{
    public class Toy : Item
    {
        public Toy(string name = "Toy", double price = 10.0) 
            : base(name, price)
        {

        }
    }
}
