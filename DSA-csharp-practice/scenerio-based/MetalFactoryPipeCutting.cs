using System;
using System.Security.Authentication.ExtendedProtection;
class MetalFactoryPipeCutting
{
    static int PipeLength=8;
    static int[] prices = {1,5,8,9,17,17,20};
    public static void Main(){
        // Scenario 1
        int OptimizedPrice = OP(PipeLength);

        // Scenario 2 Add a custom-length order and check impact on revenue.
        prices[3] = 10;
        int NewOP = OP(PipeLength);
        int ImpactOnRevenue = NewOP-OptimizedPrice;

        // Scenario 3 Visualize revenue if cut strategy is not optimized.
        int NotOP = NewOP-PipeLength;

    }

    static int OP(int length){
        int[] dp = new int[length + 1];
        dp[0] = 0;
        for (int i = 1; i <= length; i++){
            int max = int.MinValue;
            for (int j = 1; j <= i; j++){
                int current = prices[j - 1] + dp[i - j];
                if (current > max)max = current;
            }
            dp[i] = max;
        }
        return dp[length];
    }
}