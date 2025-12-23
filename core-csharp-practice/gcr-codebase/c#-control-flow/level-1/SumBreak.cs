using System;
class SumBreak
{
    public static void Main()
    {
        double total = 0;
        while (true)
        {
            double num = double.Parse(Console.ReadLine());
            if (num <= 0) break;
            total += num;
        }
        Console.WriteLine(total);
    }
}