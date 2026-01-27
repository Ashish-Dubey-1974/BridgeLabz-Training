using System;
using System.Text.RegularExpressions;

class RemoveExtraSpaces
{
    static void Main()
    {
        string text = Console.ReadLine();
        Console.WriteLine(Regex.Replace(text, @"\s+", " "));
    }
}