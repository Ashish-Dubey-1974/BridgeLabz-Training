using System;
class FactorialFor
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        Console.WriteLine(fact);
    }
}