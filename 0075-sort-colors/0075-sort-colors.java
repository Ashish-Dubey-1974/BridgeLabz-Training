class Solution {
    public void sortColors(int[] nums) {
        int i=0,j=0,k=nums.length-1;
        while(j<=k){
            if(nums[j]==2){
                swap(nums,j,k);
                k--;
            }else if(nums[j]==0){
                swap(nums,j,i);
                j++;i++;
            }
            else j++;
        }
    }void swap(int[] nums,int l,int h){
        int temp = nums[l];
        nums[l] = nums[h];
        nums[h] = temp;
    }
}