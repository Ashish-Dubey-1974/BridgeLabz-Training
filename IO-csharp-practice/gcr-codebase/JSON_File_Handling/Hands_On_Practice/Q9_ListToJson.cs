
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
class Q9_ListToJson {
    static void Main() {
        var nums = new List<int>{1,2,3};
        Console.WriteLine(JsonConvert.SerializeObject(nums));
    }
}
