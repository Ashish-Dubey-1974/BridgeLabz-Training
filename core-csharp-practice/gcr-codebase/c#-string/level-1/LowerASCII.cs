
using System;
class LowerASCII
{
    static void Main()
    {
        string s=Console.ReadLine();
        string r="";
        foreach(char c in s)
        {
            if(c>='A' && c<='Z') r+=(char)(c+32);
            else r+=c;
        }
        Console.WriteLine(r);
        Console.WriteLine(s.ToLower());
    }
}
