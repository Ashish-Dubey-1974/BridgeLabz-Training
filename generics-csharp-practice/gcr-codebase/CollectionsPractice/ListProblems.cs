
using System;
using System.Collections;
using System.Collections.Generic;

class ListProblems
{
    public static void ReverseArrayList(ArrayList list)
    {
        int l = 0, r = list.Count - 1;
        while (l < r)
        {
            object temp = list[l];
            list[l] = list[r];
            list[r] = temp;
            l++; r--;
        }
    }

    public static List<int> RemoveDuplicates(List<int> list)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();
        foreach (int i in list)
            if (seen.Add(i)) result.Add(i);
        return result;
    }
}
