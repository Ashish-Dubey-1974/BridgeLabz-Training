using System;
using System.Text.RegularExpressions;

class ExtractCurrency
{
    static void Main()
    {
        string text = Console.ReadLine();
        var matches = Regex.Matches(text, @"\$\s?\d+(\.\d{2})?");
        foreach (Match m in matches)
            Console.WriteLine(m.Value.Replace(" ", ""));
    }
}