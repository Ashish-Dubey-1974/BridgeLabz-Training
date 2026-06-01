class Solution {
    public int[] rearrangeArray(int[] nums) {
        int[] ans = new int[nums.length];
        int idxP=0,idxN=1;
        for(int i :nums){
            if(i<0){ans[idxN]=i;idxN+=2;}
            else {ans[idxP]=i;idxP+=2;}
        }return ans;
    }
}