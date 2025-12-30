using System;
public class Armstrong
{
    public static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int cp = num;
        int sum = 0;
        int order = 0;
        while (cp > 0)
        {
            order++;
            cp/=10;
        }
        cp=num;
        while (cp > 0)
        {
            int rem = cp%10;
            sum = sum+(int)Math.Pow(rem,order);
            cp/=10;
        }if(sum==num)Console.WriteLine($"{num} is a Armstrong number");
        else Console.WriteLine($"{num} is not a Armstrong number");
    }
}