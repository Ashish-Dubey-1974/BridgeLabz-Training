using System;
class countDigits
{
    public static void Main()
    {
        int num = Convert.ToInt32(Console.WriteLine());
        int digitCount = 0;
        while (num > 0)
        {
            digitCount++;
            num/=10;
        }
        Console.WriteLine($"Digits Count of Given number is {digitCount}");
    }
}