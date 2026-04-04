
using System;
using Newtonsoft.Json.Linq;
class Q12_MergeJsonFiles {
    static void Main() {
        JObject j1 = JObject.Parse("{'a':1}");
        JObject j2 = JObject.Parse("{'b':2}");
        j1.Merge(j2);
        Console.WriteLine(j1);
    }
}
