
using System;
class Matrix
{
    public static void Main()
    {
        int[,] a={{1,2},{3,4}};
        Console.WriteLine(a[0,0]*a[1,1]-a[0,1]*a[1,0]);
    }
}
