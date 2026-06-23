public class Solution {
    public int MaxProfit(int[] p) {
       int minPurchase=p[0];
       int ans=0;
       foreach(int stockPrice in p){
        if(stockPrice<minPurchase)minPurchase=stockPrice;
        else ans = ans>stockPrice-minPurchase?ans:stockPrice-minPurchase;
       }return ans;
    }
}