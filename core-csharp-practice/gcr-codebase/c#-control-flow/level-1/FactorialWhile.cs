using System;
class FactorialWhile
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long fact = 1;

        while (n > 0)
        {
            fact *= n;
            n--;
        }
        Console.WriteLine(fact);
    }
}