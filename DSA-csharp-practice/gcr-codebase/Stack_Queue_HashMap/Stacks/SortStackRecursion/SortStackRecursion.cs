using System;
using System.Collections.Generic;
class SortStackRecursion
{
    static void insert(Stack<int> s,int x)
    {
        if(s.Count==0||s.Peek()<=x){s.Push(x);return;}
        int t=s.Pop();
        insert(s,x);
        s.Push(t);
    }
    static void sort(Stack<int> s)
    {
        if(s.Count>0)
        {
            int x=s.Pop();
            sort(s);
            insert(s,x);
        }
    }
    static void Main()
    {
        Stack<int> s=new Stack<int>();
        s.Push(3);
        s.Push(1);
        s.Push(2);
        sort(s);
        while(s.Count>0) Console.WriteLine(s.Pop());
    }
}