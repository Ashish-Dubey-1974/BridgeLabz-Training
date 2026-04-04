// 3. Longest Substring Without Repeating Characters
// Medium

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> map = new HashSet<char>();
        Queue<char> q = new Queue<char>();
        int ans = 0;
        int com=0;
        for(int i=0;i<s.Length;i++){
            if(map.Contains(s[i])){
                ans = ans>com?ans:com;
                while(q.Peek()!=s[i]){
                    map.Remove(q.Dequeue());
                    com--;
                }q.Dequeue();
                q.Enqueue(s[i]);
            }else{
                map.Add(s[i]);
                q.Enqueue(s[i]);
                com++;
            }
        }return ans>com?ans:com;
    }
}