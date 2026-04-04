
using System;
using Newtonsoft.Json;
class Q15_DBToJson {
    static void Main() {
        var records = new[]{ new{Id=1,Name="Amit"}, new{Id=2,Name="Ravi"} };
        Console.WriteLine(JsonConvert.SerializeObject(records,Formatting.Indented));
    }
}
