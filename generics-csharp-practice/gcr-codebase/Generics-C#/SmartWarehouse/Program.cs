
using System;

class Program
{
    static void Main()
    {
        Storage<Electronics> store = new Storage<Electronics>();
        store.Add(new Electronics { Name = "Laptop" });
        store.ShowAll();
    }
}
