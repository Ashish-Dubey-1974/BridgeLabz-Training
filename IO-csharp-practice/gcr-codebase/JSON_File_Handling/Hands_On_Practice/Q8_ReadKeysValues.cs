
using System;
using Newtonsoft.Json.Linq;
class Q8_ReadKeysValues {
    static void Main() {
        JObject obj = JObject.Parse("{'name':'Amit','age':28}");
        foreach(var p in obj)
            Console.WriteLine(p.Key+" : "+p.Value);
    }
}
