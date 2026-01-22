using System;

class SquareRootByBinarySearch
{
    public static void Main()
    {
        int initialDataSize = 10;
        SR[] arr = new SR[initialDataSize];
        for (int i = 1; i <= arr.Length; i++)arr[i - 1] = new SR(i, Math.Sqrt(i));
        Console.Write($"Write a Number Between 1 to {initialDataSize} To find Square Root : ");
        int input = int.Parse(Console.ReadLine());
        double result = FindSqrt(arr, input);
        if (result != -1)Console.WriteLine($"Square Root of {input} : {result}");
        else Console.WriteLine("Number not found");
    }

    static double FindSqrt(SR[] arr, int num)
    {
        int l = 0;
        int r = arr.Length - 1;
        while (l <= r)
        {
            int mid = (l + r) / 2;
            if (arr[mid].Num == num)return arr[mid].Sqrt;
            if (arr[mid].Num > num)r = mid - 1;
            else l = mid + 1;
        }
        return -1;
    }
}

public class SR
{
    public int Num;
    public double Sqrt;
    public SR(int num, double sqrt)
    {
        Num = num;
        Sqrt = sqrt;
    }
}
