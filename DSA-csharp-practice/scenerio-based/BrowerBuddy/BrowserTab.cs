using System;
using System.Collections.Generic;

namespace BrowserBuddy
{
    class HistoryNode
    {
        public string Url;
        public HistoryNode Prev;
        public HistoryNode Next;

        public HistoryNode(string url)
        {
            Url = url;
        }
    }

    internal class BrowserTab
    {
        private HistoryNode current;
        private Stack<HistoryNode> closedTabs = new Stack<HistoryNode>();

        public void Visit(string url)
        {
            HistoryNode node = new HistoryNode(url);
            if (current != null)
            {
                current.Next = node;
                node.Prev = current;
            }
            current = node;
            Console.WriteLine("Visited: " + url);
        }

        public void Back()
        {
            if (current?.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Back to: " + current.Url);
            }
            else
                Console.WriteLine("No previous page");
        }

        public void Forward()
        {
            if (current?.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Forward to: " + current.Url);
            }
            else
                Console.WriteLine("No forward page");
        }

        public void Close()
        {
            if (current != null)
            {
                closedTabs.Push(current);
                Console.WriteLine("Tab closed: " + current.Url);
                current = null;
            }
        }

        public void Restore()
        {
            if (closedTabs.Count > 0)
            {
                current = closedTabs.Pop();
                Console.WriteLine("Restored tab: " + current.Url);
            }
            else
                Console.WriteLine("No closed tabs to restore");
        }
    }
}
