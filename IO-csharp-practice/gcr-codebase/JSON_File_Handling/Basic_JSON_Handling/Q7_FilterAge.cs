
using System;
using Newtonsoft.Json.Linq;
class Q7_FilterAge {
    static void Main() {
        var arr = JArray.Parse("[{'name':'A','age':20},{'name':'B','age':30}]");
        foreach(var x in arr)
            if((int)x["age"]>25)
                Console.WriteLine(x["name"]);
    }
}
