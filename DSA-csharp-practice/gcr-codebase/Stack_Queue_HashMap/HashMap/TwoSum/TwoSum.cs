using System;
using System.Collections.Generic;
class TwoSum
{
    static void Main()
    {
        int[] a={2,7,11,15};
        int t=9;
        Dictionary<int,int> m=new Dictionary<int,int>();
        for(int i=0;i<a.Length;i++)
        {
            if(m.ContainsKey(t-a[i])) Console.WriteLine(m[t-a[i]]+" "+i);
            else m[a[i]]=i;
        }
    }
}