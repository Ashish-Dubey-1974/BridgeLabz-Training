
using System;
using Newtonsoft.Json;
class Q1_StudentJson {
    static void Main() {
        var student = new {
            name = "Rahul",
            age = 22,
            subjects = new[] {"Math","Physics","CS"}
        };
        Console.WriteLine(JsonConvert.SerializeObject(student, Formatting.Indented));
    }
}
