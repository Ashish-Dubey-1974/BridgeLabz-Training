
using System;
using System.IO;

class LargeFile
{
    static void Main()
    {
        using StreamReader sr = new StreamReader("large.txt");
        string line;
        while ((line = sr.ReadLine()) != null)
            if (line.ToLower().Contains("error"))
                Console.WriteLine(line);
    }
}
