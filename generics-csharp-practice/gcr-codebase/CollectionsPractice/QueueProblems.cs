
using System;
using System.Collections.Generic;

class QueueProblems
{
    public static Queue<int> ReverseQueue(Queue<int> q)
    {
        Stack<int> s = new Stack<int>();
        while(q.Count>0) s.Push(q.Dequeue());
        while(s.Count>0) q.Enqueue(s.Pop());
        return q;
    }
}
