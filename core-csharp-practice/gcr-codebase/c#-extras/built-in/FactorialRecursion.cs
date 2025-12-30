
using System;

class FactorialRecursion
{
    static long Fact(int n)
    {
        if (n <= 1) return 1;
        return n * Fact(n - 1);
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Fact(n));
    }
}
