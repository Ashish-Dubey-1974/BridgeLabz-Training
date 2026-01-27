using System;
using System.Text.RegularExpressions;

class UsernameValidation
{
    static void Main()
    {
        string username = Console.ReadLine();
        string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";
        Console.WriteLine(Regex.IsMatch(username, pattern) ? "Valid" : "Invalid");
    }
}