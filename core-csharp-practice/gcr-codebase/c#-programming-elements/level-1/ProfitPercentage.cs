using System;
class ProfitPercentage
{
    public static void Main()
    {
        double CP = double.Parse(Console.ReadLine());
        double SP = double.Parse(Console.ReadLine());
        double profit = SP-CP;
        double profitPer = (profit/CP)*100;
        Console.WriteLine($"The Cost Price is INR {CP} and Selling Price is INR {SP} \nThe Profit is INR {profit} and the Profit Percentage is {profitPer}");
    }
}