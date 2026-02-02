
using System;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
class Q11_EmailSchema {
    static void Main() {
        string schemaJson = "{'type':'object','properties':{'email':{'type':'string','format':'email'}}}";
        JSchema schema = JSchema.Parse(schemaJson);
        JObject obj = JObject.Parse("{'email':'test@gmail.com'}");
        Console.WriteLine(obj.IsValid(schema));
    }
}
