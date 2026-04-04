using System;
using System.Text.RegularExpressions;

class HexColorValidation
{
    static void Main()
    {
        string color = Console.ReadLine();
        string pattern = @"^#[0-9a-fA-F]{6}$";
        Console.WriteLine(Regex.IsMatch(color, pattern) ? "Valid" : "Invalid");
    }
}