
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
class Q6_ListToJsonArray {
    static void Main() {
        var list = new List<string>{"A","B","C"};
        Console.WriteLine(JsonConvert.SerializeObject(list, Formatting.Indented));
    }
}
