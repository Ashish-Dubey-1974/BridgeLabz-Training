using System;
using System.Collections.Generic;
class QueueUsingStacks
{
    Stack<int> st1 = new Stack<int>();
    Stack<int> st2 = new Stack<int>();
    static void Main()
    {
        QueueUsingStacks stack = new QueueUsingStacks();
        stack.add(10);
        stack.add(20);
        Console.WriteLine(stack.pop());
    }

    void add(int num)
    {
        st1.Push(num);
    }

    int pop()
    {
        if (st2.Count == 0)while(st1.Count>0)st2.Push(st1.Pop());
        if (st2.Count == 0)
        {
            Console.WriteLine("Queue Is Empty...");
            return -1;
        }return st2.Pop();
    }
}