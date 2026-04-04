// 26. Remove Duplicates from Sorted Array
// Easy

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int ans =0;
        for(int i=1;i<nums.Length;i++){
            if(nums[i]!=nums[i-1])nums[++ans] = nums[i];
        }return ans+1;
    }
}