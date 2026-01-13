
using System;

class SearchSentence
{
    static void Main()
    {
        string[] sentences = {
            "I love C# programming",
            "Java is popular",
            "Welcome to coding"
        };

        string keyword = "C#";
        foreach (string s in sentences)
        {
            if (s.Contains(keyword))
            {
                Console.WriteLine(s);
                break;
            }
        }
    }
}
