using System;
using System.Text.RegularExpressions;

class SSNValidation
{
    static void Main()
    {
        string ssn = Console.ReadLine();
        string pattern = @"^\d{3}-\d{2}-\d{4}$";
        Console.WriteLine(Regex.IsMatch(ssn, pattern) ? "Valid" : "Invalid");
    }
}