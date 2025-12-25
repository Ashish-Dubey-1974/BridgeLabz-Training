using System;
using System.Globalization;
class Athlete
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int dis = 5000;
        double rounds = Cal(a,b,c);
        Console.WriteLine(rounds);
    }static double cal(int a,int b,int c,int dis)
    {
        return dis/(a+b+c);
    }
}