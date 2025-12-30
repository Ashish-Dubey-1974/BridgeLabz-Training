using System;
class FeetToYardMile
{
    public static void Main()
    {
        double feet = double.Parse(Console.ReadLine());

        double yards = feet / 3;
        double miles = yards / 1760;

        Console.WriteLine($"The distance in feet is {feet} which is {yards} yards and {miles} miles");
    }
}