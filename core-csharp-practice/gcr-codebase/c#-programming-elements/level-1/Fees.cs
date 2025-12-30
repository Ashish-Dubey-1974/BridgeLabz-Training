using System;
class Fees
{
    public static void Main()
    {
        int fee = 125000;
        int discountP = 10;
        double discount = (fee*discountP)/100.0;
        double discountedFees = fee - discount;
        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {discountedFees}");
    }
}