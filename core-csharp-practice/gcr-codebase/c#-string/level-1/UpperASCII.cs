
using System;
class UpperASCII
{
    static void Main()
    {
        string s=Console.ReadLine();
        string r="";
        foreach(char c in s)
        {
            if(c>='a' && c<='z') r+=(char)(c-32);
            else r+=c;
        }
        Console.WriteLine(r);
        Console.WriteLine(s.ToUpper());
    }
}
