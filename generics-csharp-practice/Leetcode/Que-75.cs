// 75. Sort Colors
// Solved
// Medium

public class Solution {
    public void SortColors(int[] nums) {
        int low=0,mid=0,high=nums.Length-1;
        while(mid<=high){
            if(nums[mid]==0){
                Swap(nums,low,mid);
                low++;
                mid++;
            }
            else if(nums[mid]==1)mid++;
            else{
                Swap(nums,high,mid);
                high--;
            }
        }
    }void Swap(int[] nums,int idx,int i){
        int temp = nums[i];
        nums[i] = nums[idx];
        nums[idx] = temp;
    }
}