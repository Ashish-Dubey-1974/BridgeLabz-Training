using System;
using System.Text.RegularExpressions;

class RepeatingWords
{
    static void Main()
    {
        string text = Console.ReadLine();
        var matches = Regex.Matches(text, @"\b(\w+)\s+\1\b", RegexOptions.IgnoreCase);
        foreach (Match m in matches)
            Console.WriteLine(m.Groups[1].Value);
    }
}