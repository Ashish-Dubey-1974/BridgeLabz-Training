
using System;
using System.Collections.Generic;

class MapProblems
{
    public static Dictionary<string,int> WordFrequency(string text)
    {
        Dictionary<string,int> map = new Dictionary<string,int>();
        string[] words = text.ToLower().Split(' ', ',', '!', '.');
        foreach(string w in words)
        {
            if(w=="") continue;
            if(!map.ContainsKey(w)) map[w]=0;
            map[w]++;
        }
        return map;
    }
}
