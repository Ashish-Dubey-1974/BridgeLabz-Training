public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        IList<int> ans = new List<int>();
        int n1=0,n2=0,cnt1=0,cnt2=0;
        int parameter = nums.Length/3;
        for(int i=0;i<nums.Length;i++){
            if(n1==nums[i])cnt1++;
            else if(n2==nums[i])cnt2++;
            else if(cnt1==0){
                n1=nums[i];
                cnt1++;
            }else if(cnt2==0){
                n2=nums[i];
                cnt2++;
            }else{
                cnt1--;
                cnt2--;
            }
        }cnt1=0;cnt2=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==n1)cnt1++;
            else if(nums[i]==n2)cnt2++;
        }
        if(cnt1>parameter)ans.Add(n1);
        if(cnt2>parameter)ans.Add(n2);
        return ans;
    }
}