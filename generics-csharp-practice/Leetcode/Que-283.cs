// 283. Move Zeroes
// Easy

public class Solution {
    public void MoveZeroes(int[] nums) {
        int idx=0;
        for(int i=0;i<nums.Length;i++){
            while(idx<nums.Length && nums[idx]!=0)idx++;
            if(idx<i && nums[i]!=0){
                int temp = nums[i];
                nums[i] = nums[idx];
                nums[idx] = temp;
                i = idx++;
            }
        }
    }
}