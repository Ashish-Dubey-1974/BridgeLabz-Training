// 189. Rotate Array
// Medium

public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k%nums.Length;
        reverse(nums,0,nums.Length-k);
        reverse(nums,nums.Length-k,nums.Length);
        reverse(nums,0,nums.Length);
    }
    void reverse(int[] nums,int st,int ed){
        ed--;
        while(st<ed){
            int temp = nums[st];
            nums[st] = nums[ed];
            nums[ed] = temp;
            st++;
            ed--;
        }
    }
}