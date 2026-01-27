using System;
using System.Text.RegularExpressions;

class CensorBadWords
{
    static void Main()
    {
        string text = Console.ReadLine();
        string pattern = @"\b(damn|stupid)\b";
        Console.WriteLine(Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase));
    }
}