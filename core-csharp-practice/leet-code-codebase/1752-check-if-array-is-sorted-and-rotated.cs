public class Solution {
    public bool Check(int[] nums) {
        if(nums.Length<=2)return true;
        int count=0;
        for(int i=1;i<nums.Length;i++){
            if(nums[i-1]>nums[i])count++;
        }if(count==1)if(nums[0]<nums[nums.Length-1])return false;
        return count<=1;
    }
}