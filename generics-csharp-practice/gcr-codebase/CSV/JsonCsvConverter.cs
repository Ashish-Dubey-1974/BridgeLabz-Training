
using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class Student {
    public int Id {get;set;}
    public string Name {get;set;}
}

class Program {
    static void Main() {
        var json = File.ReadAllText("students.json");
        var list = JsonSerializer.Deserialize<List<Student>>(json);

        using(var sw = new StreamWriter("students.csv")) {
            sw.WriteLine("Id,Name");
            foreach(var s in list)
                sw.WriteLine($"{s.Id},{s.Name}");
        }
    }
}
