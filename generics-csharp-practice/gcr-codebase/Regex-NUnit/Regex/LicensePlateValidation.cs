using System;
using System.Text.RegularExpressions;

class LicensePlateValidation
{
    static void Main()
    {
        string plate = Console.ReadLine();
        string pattern = @"^[A-Z]{2}[0-9]{4}$";
        Console.WriteLine(Regex.IsMatch(plate, pattern) ? "Valid" : "Invalid");
    }
}