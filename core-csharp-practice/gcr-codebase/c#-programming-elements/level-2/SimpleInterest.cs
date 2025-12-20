using System;
class SimpleInterest
{
    public static void Main()
    {
        double principal = double.Parse(Console.ReadLine());
        double rate = double.Parse(Console.ReadLine());
        double time = double.Parse(Console.ReadLine());
        double interest = (principal * rate * time) / 100;
        Console.WriteLine($"The Simple Interest is {interest} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    }
}