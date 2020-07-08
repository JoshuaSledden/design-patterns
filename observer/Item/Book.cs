using System;
using System.Collections.Generic;
using System.Text;

namespace observer
{
    public class Book : Item
    {
        public Book(string name = "Book", double price = 5.0)
            : base(name, price)
        {

        }
    }
}
