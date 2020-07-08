using System;
using System.Collections.Generic;
using System.Text;

namespace observer
{
    public class Customer : ICustomer
    {
        private string _name;
        private Item _item;

        public Customer(string name)
        {
            _name = name;
        }

        public void Update(Item item)
        {
            _item = item;
            Console.WriteLine($"Notified {_name} of {_item.Name}'s " +
                $"price change to {_item.Price:C}");
        }

        public Item Item
        {
            get { return _item; }
            set { _item = value; }
        }
    }
}
