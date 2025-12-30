using System;
class SumCompareWhile
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n > 0)
        {
            int sum1 = 0;
            int i = 1;
            while (i <= n)
            {
                sum1 += i;
                i++;
            }
            int sum2 = n * (n + 1) / 2;
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
    }
}