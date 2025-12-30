using System;
class SumOfNumber
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Count(n));
    }
    static int Count(int n)
    {
        int sum=0;
        for(int i = 1; i <= n; i++)sum+=i;
        return sum;
    }
}