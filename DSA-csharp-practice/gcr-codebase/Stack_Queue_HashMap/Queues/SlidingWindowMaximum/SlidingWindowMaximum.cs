using System;
using System.Collections.Generic;
class SlidingWindowMaximum
{
    static void Main()
    {
        int[] a={1,3,-1,-3,5,3,6,7};
        int k=3;
        LinkedList<int> d=new LinkedList<int>();
        for(int i=0;i<a.Length;i++)
        {
            if(d.Count>0&&d.First.Value<=i-k) d.RemoveFirst();
            while(d.Count>0&&a[d.Last.Value]<=a[i]) d.RemoveLast();
            d.AddLast(i);
            if(i>=k-1) Console.WriteLine(a[d.First.Value]);
        }
    }
}