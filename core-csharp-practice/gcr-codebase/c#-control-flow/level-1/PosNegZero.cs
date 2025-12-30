using System;
class PosNegZero
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num > 0) Console.WriteLine("positive");
        else if (num < 0) Console.WriteLine("negative");
        else Console.WriteLine("zero");
    }
}