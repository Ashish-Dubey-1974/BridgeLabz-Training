using System;
class HandShakes
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int HandShakes_ = Calculate(n);
        Console.WriteLine($"The maximum number of handshakes among {n} studends {HandShakes_}");
    }
    static int Calculate(int n)
    {
        return (n*(n-1))/2;
        
    }
}