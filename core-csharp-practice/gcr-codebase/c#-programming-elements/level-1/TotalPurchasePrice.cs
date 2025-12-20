using System;
class TotalPurchasePrice
{
    public static void Main()
    {
        double unitPrice = double.Parse(Console.ReadLine());
        int quantity = int.Parse(Console.ReadLine());

        double TPrice = unitPrice * quantity;

        Console.WriteLine($"The total purchase price is INR {TPrice} if the quantity {quantity} and unit price is INR {unitPrice}");
    }
}