
using System;
using System.Xml;
using Newtonsoft.Json;
class Q13_JsonToXml {
    static void Main() {
        string json = "{'name':'Amit','age':28}";
        XmlDocument doc = JsonConvert.DeserializeXmlNode(json,"Root");
        Console.WriteLine(doc.OuterXml);
    }
}
