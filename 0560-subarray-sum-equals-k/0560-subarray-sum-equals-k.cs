public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int preSum=0;
        int cnt=0;
        Dictionary<int,int> map = new Dictionary<int,int>();
        map[0]=1;
        for(int i=0;i<nums.Length;i++){
            preSum+=nums[i];
            if(map.ContainsKey(preSum-k))cnt+=map[preSum-k];
            map[preSum]=map.GetValueOrDefault(preSum,0)+1;
        }return cnt;
    }
}