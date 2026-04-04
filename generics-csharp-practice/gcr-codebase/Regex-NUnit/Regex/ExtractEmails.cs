using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string text = Console.ReadLine();
        var matches = Regex.Matches(text, @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}");
        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}