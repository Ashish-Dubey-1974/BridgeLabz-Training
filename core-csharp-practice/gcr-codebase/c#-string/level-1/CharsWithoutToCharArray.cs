
using System;
class CharReturn
{
    static void Main()
    {
        string s=Console.ReadLine();
        for(int i=0;i<s.Length;i++)Console.Write(s[i]+" ");
        Console.WriteLine();
        foreach(char c in s.ToCharArray())Console.Write(c+" ");
    }
}
