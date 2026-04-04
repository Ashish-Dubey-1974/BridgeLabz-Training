using System;
using System.Collections.Generic;
class ZeroSumSubarrays
{
    static void Main()
    {
        int[] a={1,-1,2,-2,3};
        Dictionary<int,int> m=new Dictionary<int,int>();
        int s=0;
        m[0]=1;
        for(int i=0;i<a.Length;i++)
        {
            s+=a[i];
            if(m.ContainsKey(s)) Console.WriteLine("Yes");
            else m[s]=1;
        }
    }
}