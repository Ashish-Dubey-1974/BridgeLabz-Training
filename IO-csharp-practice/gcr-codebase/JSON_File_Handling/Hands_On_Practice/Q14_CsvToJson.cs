
using System;
using Newtonsoft.Json;
class Q14_CsvToJson {
    static void Main() {
        var data = new[]{ new{Id=1,Name="A"}, new{Id=2,Name="B"} };
        Console.WriteLine(JsonConvert.SerializeObject(data));
    }
}
