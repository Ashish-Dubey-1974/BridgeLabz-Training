
using System.Collections.Generic;

namespace SmartCheckout
{
    internal class Customer
    {
        public string Name;
        public Queue<string> Items;

        public Customer(string name)
        {
            Name = name;
            Items = new Queue<string>();
        }
    }
}
