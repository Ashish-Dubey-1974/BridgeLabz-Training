
using System;

namespace SmartCheckout
{
    internal class Menu
    {
        public static void Display()
        {
            ICheckout obj = new Utility();
            do
            {
                Console.WriteLine("\n--- Smart Checkout ---");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Remove Customer");
                Console.WriteLine("3. Process Billing");
                Console.WriteLine("4. Display Queue");
                Console.WriteLine("5. Exit");

                int ch = int.Parse(Console.ReadLine());

                if (ch == 1) obj.AddCustomer();
                else if (ch == 2) obj.RemoveCustomer();
                else if (ch == 3) obj.ProcessBilling();
                else if (ch == 4) obj.DisplayQueue();
                else break;

            } while (true);
        }
    }
}
