
using System;

class PasswordCracker
{
    static bool found = false;

    static void Main()
    {
        string password = "ab1";
        int length = password.Length;

        Console.WriteLine("Cracking Password...");
        Generate("", length, password);
    }

    static void Generate(string current, int length, string password)
    {
        if (found) return;

        if (current.Length == length)
        {
            Console.WriteLine(current);
            if (current == password)
            {
                Console.WriteLine("Password Matched!");
                found = true;
            }
            return;
        }

        string chars = "abc123";
        foreach (char c in chars)
            Generate(current + c, length, password);
    }
}
