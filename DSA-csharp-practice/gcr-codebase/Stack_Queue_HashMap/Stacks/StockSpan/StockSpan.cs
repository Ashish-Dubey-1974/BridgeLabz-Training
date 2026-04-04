using System;
using System.Collections.Generic;
class StockSpan
{
    static void Main()
    {
        int[] a={100,80,60,70,60,75,85};
        Stack<int> s=new Stack<int>();
        for(int i=0;i<a.Length;i++)
        {
            while(s.Count>0&&a[s.Peek()]<=a[i]) s.Pop();
            Console.WriteLine(s.Count==0?i+1:i-s.Peek());
            s.Push(i);
        }
    }
}