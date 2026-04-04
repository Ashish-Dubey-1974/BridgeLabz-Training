
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordCount
{
    static void Main()
    {
        Dictionary<string,int> dict = new Dictionary<string,int>();

        foreach (var word in File.ReadAllText("data.txt").Split())
        {
            string w = word.ToLower();
            if (!dict.ContainsKey(w)) dict[w]=0;
            dict[w]++;
        }

        foreach (var item in dict.OrderByDescending(x=>x.Value).Take(5))
            Console.WriteLine(item.Key + " : " + item.Value);
    }
}
