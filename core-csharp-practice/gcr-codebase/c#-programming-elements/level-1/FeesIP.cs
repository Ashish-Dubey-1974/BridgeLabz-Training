using System;
class FeesIP
{
    public static void Main()
    {
        int fee = int.Parse(Console.ReadLine());
        int discountP = int.Parse(Console.ReadLine());
        double discount = (fee*discountP)/100.0;
        double discountedFees = fee - discount;
        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {discountedFees}");
    }
}