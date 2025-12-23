using System;
class Table
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{n} * {i} = {n * i}");
        }
    }
}