using System;
class Largest
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(a > b && a > c);
        Console.WriteLine(b > a && b > c);
        Console.WriteLine(c > a && c > b);
    }
}