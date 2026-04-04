
using System;
using Newtonsoft.Json.Linq;
class Q3_ReadJsonExtract {
    static void Main() {
        JObject obj = JObject.Parse("{'name':'Amit','email':'amit@gmail.com','age':25}");
        Console.WriteLine(obj["name"]);
        Console.WriteLine(obj["email"]);
    }
}
