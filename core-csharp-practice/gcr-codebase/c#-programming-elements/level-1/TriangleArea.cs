using System;
class TriangleArea
{
    public static void Main()
    {
        double baseValue = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double areaInches = 0.5 * baseValue * height;
        double areaCm = areaInches * 6.4516;

        Console.WriteLine($"The area of triangle is {areaInches} square inches and {areaCm} square centimeters");
    }
}