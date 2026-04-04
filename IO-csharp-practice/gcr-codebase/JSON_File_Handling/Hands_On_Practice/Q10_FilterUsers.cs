
using System;
using Newtonsoft.Json.Linq;
class Q10_FilterUsers {
    static void Main() {
        var arr = JArray.Parse("[{'name':'A','age':20},{'name':'B','age':35}]");
        foreach(var u in arr)
            if((int)u["age"]>25)
                Console.WriteLine(u["name"]);
    }
}
