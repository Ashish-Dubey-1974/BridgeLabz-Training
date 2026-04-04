using System;
using System.Collections.Generic;
class LongestConsecutive
{
    static void Main()
    {
        int[] a={100,4,200,1,3,2};
        HashSet<int> s=new HashSet<int>(a);
        int ans=0;
        foreach(int x in a)
        {
            if(!s.Contains(x-1))
            {
                int c=x,len=1;
                while(s.Contains(c+1)){c++;len++;}
                ans=Math.Max(ans,len);
            }
        }
        Console.WriteLine(ans);
    }
}