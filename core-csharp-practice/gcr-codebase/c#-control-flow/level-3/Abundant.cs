using System;
class Abundant
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sum=1;
        for(int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)sum = sum+i+(num/i);
        }
        if(sum>num)Console.WriteLine($"{num} is a Abundant number");
        else Console.WriteLine($"{num} is not a Abundant number");
    } 
}