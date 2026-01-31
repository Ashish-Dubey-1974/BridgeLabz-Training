// 121. Best Time to Buy and Sell Stock
// Solved
// Easy

public class Solution {
    public int MaxProfit(int[] p) {
       int minp = p[0];
       int sum=0;
       for(int i=1;i<p.Length;i++){
        if(minp>p[i])minp = p[i];
        else{
            int com = p[i]-minp;
            sum = sum>com?sum:com;
        }
       }return sum;
    }
}