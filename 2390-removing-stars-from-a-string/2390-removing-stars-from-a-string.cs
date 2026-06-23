public class Solution {
    public string RemoveStars(string s) {
        char[] arr = new char[s.Length];
        int n=0;
        foreach(char c in s){
            if(c=='*')n--;
            else arr[n++]=c;
        }
        return new String(arr.AsSpan()[..n]);
    }
}