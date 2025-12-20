using System;
class Chocolates
{
    public static void Main()
    {
        int chocolates = int.Parse(Console.ReadLine());
        int children = int.Parse(Console.ReadLine());
        int each = chocolates / children;
        int remaining = chocolates % children;
        Console.WriteLine($"The number of chocolates each child gets is {each} and the number of remaining chocolates is {remaining}");
    }
}