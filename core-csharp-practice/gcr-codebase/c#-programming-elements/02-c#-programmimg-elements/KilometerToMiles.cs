using System;
class KilometerToMiles
{
    public static void Main()
    {
        Console.WriteLine("Enter KM");
        int km = int.Parse(Console.ReadLine());
        float miles = km/1.6f;
        Console.WriteLine($"The distance {km} km in miles is {miles}"); 
    }
}