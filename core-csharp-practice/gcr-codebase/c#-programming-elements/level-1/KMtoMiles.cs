using System;
class KMtoMiles
{
    public static void Main()
    {
        Console.WriteLine("Enter KM");
        double km = double.Parse(Console.ReadLine());
        double miles = km/1.6;
        Console.WriteLine($"The distance {km} km in miles is {miles}"); 
    }
}