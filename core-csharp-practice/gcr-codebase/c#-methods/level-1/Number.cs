using System;
class Number
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(check(n));
    }static int check(int n)
    {
        if(n==0)return 0;
        else if(n<0)return -1;
        return 1;
    }
}