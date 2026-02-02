
using System;
using Newtonsoft.Json.Linq;
class Q4_MergeJson {
    static void Main() {
        JObject j1 = JObject.Parse("{'name':'Amit'}");
        JObject j2 = JObject.Parse("{'age':28}");
        j1.Merge(j2);
        Console.WriteLine(j1);
    }
}
