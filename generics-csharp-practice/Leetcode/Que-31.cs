// 31. Next Permutation
// Solved
// Medium

public class Solution {
    public void NextPermutation(int[] nums) {
        int pivot = -1;
        for(int i=nums.Length-2;i>=0;i--)if(nums[i]<nums[i+1]){
            pivot=i;
            break;
        }
        if(pivot==-1)reverse(nums,0,nums.Length-1);
        else{
            for(int i=nums.Length-1;i>=0;i--){
                if(nums[pivot]<nums[i]){
                    swap(nums,pivot,i);
                    break;
                }
            }reverse(nums,pivot+1,nums.Length-1);
        }
    }public void reverse(int[] nums,int st,int ed){
        while(st<ed)swap(nums,st++,ed--);
    }
    public void swap(int[] nums,int st,int ed){
        int temp = nums[st];
        nums[st] = nums[ed];
        nums[ed] = temp;
    }
}