
using System;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
class Q5_ValidateSchema {
    static void Main() {
        string schemaJson = "{ 'type':'object','properties':{'name':{'type':'string'}} }";
        JSchema schema = JSchema.Parse(schemaJson);
        JObject obj = JObject.Parse("{'name':'Amit'}");
        Console.WriteLine(obj.IsValid(schema));
    }
}
