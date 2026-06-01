class Solution {
    public int majorityElement(int[] nums) {
        int ans=nums[0];
        int cnt=1;
        for(int i=1;i<nums.length;i++){
            if(cnt==0){cnt++;ans=nums[i];}
            else if(nums[i]==ans)cnt++;
            else cnt--;
        }return ans;
    }
}