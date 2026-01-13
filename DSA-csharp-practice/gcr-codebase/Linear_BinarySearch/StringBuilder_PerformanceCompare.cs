
using System;
using System.Text;
using System.Diagnostics;

class PerformanceCompare
{
    static void Main()
    {
        int iterations = 100000;
        Stopwatch sw = new Stopwatch();

        sw.Start();
        string s = "";
        for (int i = 0; i < iterations; i++)
            s += "a";
        sw.Stop();
        Console.WriteLine("String Time: " + sw.ElapsedMilliseconds);

        sw.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
            sb.Append("a");
        sw.Stop();
        Console.WriteLine("StringBuilder Time: " + sw.ElapsedMilliseconds);
    }
}
