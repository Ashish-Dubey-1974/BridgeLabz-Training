
using System;

class GcdLcm
{
    static int GCD(int a, int b)
    {
        if(b==0)return a;
        return GCD(b,a%b);
    }

    static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("GCD: " + GCD(a, b));
        Console.WriteLine("LCM: " + LCM(a, b));
    }
}
