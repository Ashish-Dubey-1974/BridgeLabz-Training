
using System;
class SubstringUsingIndex
{
        static void Main()
    {
        string s=Console.ReadLine();
        int st=int.Parse(Console.ReadLine());
        int en=int.Parse(Console.ReadLine());
        Console.WriteLine(GetSub(s,st,en));
        Console.WriteLine(s.Substring(st,en-st+1));
    }
    static string GetSub(string s,int start,int end)
    {
        string r="";
        for(int i=start;i<=end;i++) r+=s[i];
        return r;
    }
}
