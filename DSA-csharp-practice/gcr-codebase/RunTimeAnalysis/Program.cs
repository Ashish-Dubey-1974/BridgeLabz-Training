
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace RuntimeAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Runtime Analysis & Big-O Demonstration");

            SearchComparison();
            SortingComparison();
            StringConcatComparison();
            FibonacciComparison();

            Console.WriteLine("\nDone.");
        }

        static void SearchComparison()
        {
            int n = 1000000;
            var data = Enumerable.Range(1, n).ToList();
            int target = n;

            var sw = Stopwatch.StartNew();
            data.Contains(target);
            sw.Stop();
            Console.WriteLine($"Linear Search: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            data.BinarySearch(target);
            sw.Stop();
            Console.WriteLine($"Binary Search: {sw.ElapsedMilliseconds} ms");
        }

        static void SortingComparison()
        {
            int n = 10000;
            var rand = new Random();
            int[] arr = Enumerable.Range(0, n).Select(_ => rand.Next()).ToArray();

            var sw = Stopwatch.StartNew();
            Array.Sort(arr);
            sw.Stop();
            Console.WriteLine($"QuickSort/Array.Sort: {sw.ElapsedMilliseconds} ms");
        }

        static void StringConcatComparison()
        {
            int n = 100000;
            var sw = Stopwatch.StartNew();
            string s = "";
            for (int i = 0; i < n; i++) s += "a";
            sw.Stop();
            Console.WriteLine($"String concat: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++) sb.Append("a");
            sb.ToString();
            sw.Stop();
            Console.WriteLine($"StringBuilder concat: {sw.ElapsedMilliseconds} ms");
        }

        static void FibonacciComparison()
        {
            int n = 40;

            var sw = Stopwatch.StartNew();
            FibonacciRecursive(n);
            sw.Stop();
            Console.WriteLine($"Recursive Fibonacci: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            FibonacciIterative(n);
            sw.Stop();
            Console.WriteLine($"Iterative Fibonacci: {sw.ElapsedMilliseconds} ms");
        }

        static int FibonacciRecursive(int n)
        {
            if (n <= 1) return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        static int FibonacciIterative(int n)
        {
            if (n <= 1) return n;
            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }
    }
}
