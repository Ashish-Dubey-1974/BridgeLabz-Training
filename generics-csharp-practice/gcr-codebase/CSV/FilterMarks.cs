
using System;
using System.IO;

class Program {
    static void Main() {
        var lines = File.ReadAllLines("students.csv");
        for(int i=1;i<lines.Length;i++) {
            var d = lines[i].Split(',');
            if(int.Parse(d[3]) > 80)
                Console.WriteLine(string.Join(", ", d));
        }
    }
}
