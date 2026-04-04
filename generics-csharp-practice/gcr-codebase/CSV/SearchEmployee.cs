
using System;
using System.IO;

class Program {
    static void Main() {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        var lines = File.ReadAllLines("employees.csv");

        for(int i=1;i<lines.Length;i++) {
            var d = lines[i].Split(',');
            if(d[1].Equals(name, StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine($"Department: {d[2]}, Salary: {d[3]}");
            }
        }
    }
}
