
using System;

class Fibonacci
{
    static int[] dp;
    static int PrintFib(int n)
    {
        if(n==0 || n==1)return n;
        if(dp[n]!=-1)return dp[n];
        return dp[n]=PrintFib(n-1)+PrintFib(n-2);
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        dp = new int[n+1];
        for(int i=0;i<n+1;i++)dp[i]=-1;
        int ans = PrintFib(n);
        Console.WriteLine(ans);
    }
}
