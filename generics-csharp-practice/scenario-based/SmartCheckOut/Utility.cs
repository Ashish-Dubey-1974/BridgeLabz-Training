
using System;
using System.Collections.Generic;

namespace SmartCheckout
{
    internal class Utility : ICheckout
    {
        Queue<Customer> queue = new Queue<Customer>();
        Store store = new Store();

        public void AddCustomer()
        {
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();
            Customer c = new Customer(name);

            Console.WriteLine("Enter items (type 'done' to stop):");
            while (true)
            {
                string item = Console.ReadLine();
                if (item.ToLower() == "done") break;
                c.Items.Enqueue(item);
            }

            queue.Enqueue(c);
            Console.WriteLine("Customer added to billing queue.");
        }

        public void RemoveCustomer()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue empty.");
                return;
            }

            Customer c = queue.Dequeue();
            Console.WriteLine($"Customer {c.Name} removed from queue.");
        }

        public void ProcessBilling()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("No customers in queue.");
                return;
            }

            Customer c = queue.Peek();
            double total = 0;

            Console.WriteLine($"Billing for {c.Name}:");

            while (c.Items.Count > 0)
            {
                string item = c.Items.Dequeue();

                if (!store.PriceMap.ContainsKey(item))
                {
                    Console.WriteLine($"{item} not found.");
                    continue;
                }

                if (store.StockMap[item] <= 0)
                {
                    Console.WriteLine($"{item} out of stock.");
                    continue;
                }

                total += store.PriceMap[item];
                store.StockMap[item]--;

                Console.WriteLine($"{item} : {store.PriceMap[item]}");
            }

            Console.WriteLine($"Total Bill = {total}");
            queue.Dequeue();
        }

        public void DisplayQueue()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue empty.");
                return;
            }

            foreach (var c in queue)
                Console.WriteLine(c.Name);
        }
    }
}
