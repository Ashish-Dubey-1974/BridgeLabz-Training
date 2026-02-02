
using System;
using Newtonsoft.Json;
class Car {
    public string Brand {get;set;}
    public int Price {get;set;}
}
class Q2_CarToJson {
    static void Main() {
        Car c = new Car{Brand="Honda",Price=900000};
        Console.WriteLine(JsonConvert.SerializeObject(c, Formatting.Indented));
    }
}
