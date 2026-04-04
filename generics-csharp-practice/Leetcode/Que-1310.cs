// 1310. XOR Queries of a Subarray
// Medium
public class Solution {
    public int[] XorQueries(int[] a, int[][] q) {
        int[] ans = new int[q.Length];
        int[] xor = new int[a.Length];
        xor[0] = a[0];
        for(int i=1;i<a.Length;i++)xor[i]=a[i]^xor[i-1];
        for(int i=0;i<q.Length;i++){
            if(q[i][0]==0)ans[i] = xor[q[i][1]];
            else ans[i] = xor[q[i][1]]^xor[q[i][0]-1];
        }
        return ans;
    }
}