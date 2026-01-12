using System;

class RodCutting
{
    static int MaxProfit(int[] price, int n)
    {
        int[] dp = new int[n + 1];
        dp[0] = 0;
        for (int i = 1; i <= n; i++){
            int max = 0;
            for (int j = 1; j <= i; j++){
                max = Math.Max(max, price[j] + dp[i - j]);
            }
            dp[i] = max;
        }
        return dp[n];
    }

    static void Main(){
        int[] price = { 0,2,5,7,8,10,13,17,18,20,24,25,30 };
        int rodLength = 12;
        Console.WriteLine("Maximum Earnings: ₹" + MaxProfit(price, rodLength));
    }
}
