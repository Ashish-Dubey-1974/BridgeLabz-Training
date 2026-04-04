
using System;

class FirstNegative
{
    static void Main()
    {
        int[] arr = { 3, 5, -2, 7, -9 };
        foreach (int x in arr)
        {
            if (x < 0)
            {
                Console.WriteLine(x);
                break;
            }
        }
    }
}
