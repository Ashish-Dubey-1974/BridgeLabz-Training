using System;
class CountdownWhile
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        while (n >= 1)
        {
            Console.WriteLine(n);
            n--;
        }
    }
}