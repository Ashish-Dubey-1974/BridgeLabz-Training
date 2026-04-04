
using System;
using System.IO;

class WordCount
{
    static void Main()
    {
        string word = "test";
        int count = 0;

        using (StreamReader sr = new StreamReader("input.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(word))
                    count++;
            }
        }
        Console.WriteLine("Occurrences: " + count);
    }
}
