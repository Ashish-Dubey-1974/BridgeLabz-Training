using System;
using System.Text.RegularExpressions;

class ExtractLanguages
{
    static void Main()
    {
        string text = Console.ReadLine();
        var matches = Regex.Matches(text, @"\b(JavaScript|Java|Python|Go)\b");
        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}