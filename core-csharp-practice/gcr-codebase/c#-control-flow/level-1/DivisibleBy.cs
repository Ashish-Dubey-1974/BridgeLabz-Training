using System;
class divisibleBy
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        String str = "";
        if(num%5==0)str = "Yes";
        else str = "No";
        Console.WriteLine($"Is the number {num} divisible by 5? {str}");
    }
}
