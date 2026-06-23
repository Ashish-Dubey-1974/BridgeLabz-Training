public class Solution {
    public string RemoveStars(string s) {
        Stack<char> st = new Stack<char>();
        foreach(char c in s){
            if(c=='*')st.Pop();
            else st.Push(c);
        }StringBuilder sb = new StringBuilder();
        while(st.Count()!=0)sb.Append(st.Pop());
        Reverse(sb);
        return sb.ToString();
    }void Reverse(StringBuilder sb){
        int left =0;
        int right=sb.Length-1;
        while(left<right){
            char temp = sb[left];
            sb[left]=sb[right];
            sb[right]=temp;
            right--;
            left++;
        }
    }
}