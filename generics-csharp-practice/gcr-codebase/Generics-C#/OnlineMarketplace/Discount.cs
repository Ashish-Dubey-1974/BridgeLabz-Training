
using System;

class Discount
{
    public static void ApplyDiscount<T>(T product, double percent) where T : Product
    {
        product.Price -= product.Price * percent / 100;
        Console.WriteLine("New Price: " + product.Price);
    }
}
