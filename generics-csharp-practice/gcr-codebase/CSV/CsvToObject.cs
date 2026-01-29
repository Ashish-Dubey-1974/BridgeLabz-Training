
using System;
using System.IO;
using System.Collections.Generic;

class Student {
    public int Id;
    public string Name;
    public int Age;
}

class Program {
    static void Main() {
        var students = new List<Student>();
        var lines = File.ReadAllLines("students.csv");

        for(int i=1;i<lines.Length;i++) {
            var d = lines[i].Split(',');
            students.Add(new Student {
                Id = int.Parse(d[0]),
                Name = d[1],
                Age = int.Parse(d[2])
            });
        }

        foreach(var s in students)
            Console.WriteLine($"{s.Id} {s.Name} {s.Age}");
    }
}
