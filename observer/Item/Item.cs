using System;
using System.Collections.Generic;
using System.Text;

namespace observer
{
    public abstract class Item
    {
        private string _name;
        private double _price;
        private List<ICustomer> _customers = new List<ICustomer>();

        public Item(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public ICustomer Attach(ICustomer customer)
        {
            customer.Item = this;
            _customers.Add(customer);
            return customer;
        }

        public void Detach(ICustomer customer)
        {
            customer.Item = null;
            _customers.Remove(customer);
        }

        public void Notify()
        {
            foreach(ICustomer customer in _customers)
            {
                customer.Update(this);
            }
        }

        public int CustomerCount
        {
            get { return _customers.Count; }
        }

        public string Name
        {
            get { return _name; }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if(_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }
    }
}
