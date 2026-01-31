public class Solution {
    public int MaxSubArray(int[] nums) {
        int sum=int.MinValue;
        int c=0;
        for(int i=0;i<nums.Length;i++){
            c+=nums[i];
            if(sum<c)sum=c;
            if(c<0)c=0;
        }return sum;
    }
}