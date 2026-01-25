// 485. Max Consecutive Ones
// Easy

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int sum=0;
        int com=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=1){
                sum = sum>com?sum:com;
                com=0;
            }else com++;
        }return sum>com?sum:com;
    }
}