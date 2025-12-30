using System;
class SumUntilZero
{
    public static void Main()
    {
        double total = 0;
        double num = double.Parse(Console.ReadLine());
        while (num != 0)
        {
            total += num;
            num = double.Parse(Console.ReadLine());
        }
        Console.WriteLine(total);
    }
}