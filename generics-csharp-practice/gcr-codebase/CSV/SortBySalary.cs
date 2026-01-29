
using System;
using System.IO;
using System.Linq;

class Program {
    static void Main() {
        var lines = File.ReadAllLines("employees.csv").Skip(1)
            .Select(l => l.Split(','))
            .OrderByDescending(d => double.Parse(d[3]))
            .Take(5);

        foreach (var e in lines)
            Console.WriteLine(string.Join(", ", e));
    }
}
