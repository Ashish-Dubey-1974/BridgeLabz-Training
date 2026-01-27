using System;
using System.Text.RegularExpressions;

class ExtractLinks
{
    static void Main()
    {
        string text = Console.ReadLine();
        var matches = Regex.Matches(text, @"https?://[^\s]+");
        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}