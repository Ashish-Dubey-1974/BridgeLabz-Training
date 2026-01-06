using System;

class BusRouteDistanceTracker
{
    static void Main()
    {
        int totalDistance = 0;
        string choice = "no";

        while (choice != "yes")
        {
            Console.Write("Enter distance of next stop (in km): ");
            int distance = Convert.ToInt32(Console.ReadLine());

            totalDistance += distance;
            Console.WriteLine("Total distance travelled: " + totalDistance + " km");

            Console.Write("Do you want to get off the bus? (yes/no): ");
            choice = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Passenger got off. Final distance: " + totalDistance + " km");
    }
}
