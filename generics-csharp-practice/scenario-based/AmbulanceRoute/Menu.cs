
using System;

namespace AmbulanceRoute
{
    internal class Menu
    {
        public static void Display()
        {
            IRoute obj = new Utility();

            do
            {
                Console.WriteLine("\n--- Ambulance Emergency Route ---");
                Console.WriteLine("1. Add Hospital Unit");
                Console.WriteLine("2. Remove Unit (Maintenance)");
                Console.WriteLine("3. Find Available Unit");
                Console.WriteLine("4. Display Circular Route");
                Console.WriteLine("5. Exit");

                int ch = int.Parse(Console.ReadLine());

                if (ch == 1) obj.AddUnit();
                else if (ch == 2) obj.RemoveUnit();
                else if (ch == 3) obj.FindAvailableUnit();
                else if (ch == 4) obj.DisplayRoute();
                else break;

            } while (true);
        }
    }
}
