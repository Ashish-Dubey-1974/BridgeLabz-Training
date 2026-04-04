
using System;

class Groceries : WarehouseItem
{
    public override void Display()
    {
        Console.WriteLine("Grocery Item: " + Name);
    }
}
