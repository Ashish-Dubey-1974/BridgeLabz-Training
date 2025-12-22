using System;
class HarshadNum
{
    public static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int sum =0;
        int cp=num;
        while (cp > 0)
        {
            int rem = cp%10;
            sum +=rem;
            cp/=10;
        }
        if(num%sum==0)Console.WriteLine($"{num} is a Harshad number");
        else Console.WriteLine($"{num} is not a Harshad number");
    }
}