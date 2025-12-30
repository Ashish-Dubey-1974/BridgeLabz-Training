using System;
class SumCompareFor
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n > 0)
        {
            int sum1 = 0;
            for (int i = 1; i <= n; i++)
            {
                sum1 += i;
            }
            int sum2 = n * (n + 1) / 2;
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
    }
}