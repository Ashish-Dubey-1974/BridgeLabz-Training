
using System;

class Palindrome
{
    static bool Check(string s)
    {
        int i = 0, j = s.Length - 1;
        while (i < j)if(s[i++] != s[j--]) return false;
        return true;
    }

    static void Main()
    {
        string s = Console.ReadLine();
        Console.WriteLine(Check(s) ? "Palindrome" : "Not Palindrome");
    }
}
