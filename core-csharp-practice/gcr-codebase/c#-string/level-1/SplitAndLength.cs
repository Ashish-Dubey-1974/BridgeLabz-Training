
using System;
class WordLength
{
    static int Len(string s)
    {
        int c=0; 
        foreach(char x in s) c++; 
        return c;
    }
    static void Main()
    {
        string s=Console.ReadLine();
        s=s.Trim();
        int n=0;
        foreach (char x in s)if(x==' ')n++;
        string[,] ans = new string[n+1,2];
        int idx=0;
        string word="";
        for(int i=0;i<s.Length;i++)
        {
            if(s[i]!=' ') word+=s[i];
            else
            {
                ans[idx,0] = word;
                ans[idx++,1] = Len(word).ToString();
                word="";
            }
        }
        if (word != "")
        {
            ans[idx,0] = word;
            ans[idx,1] = Len(word).ToString();
        } 
        for (int i = 0; i < n+1; i++)Console.WriteLine(ans[i, 0] + " " + ans[i, 1]);
    }
}
