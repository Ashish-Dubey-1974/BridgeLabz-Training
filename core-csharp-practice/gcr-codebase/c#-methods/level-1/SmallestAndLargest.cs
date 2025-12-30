using System;
class SmallestAndLargest
{
    public static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int[] arr = FindSmallestAndLargest(num1,num2,num3);
        Console.WriteLine($"Smallest : {arr[0]} \nLargest : {arr[1]}");
    }static int[] FindSmallestAndLargest(int a,int b,int c)
    {
        int s = Math.Min(a,Math.Min(b,c));
        int l = Math.Max(a,Math.Max(b,c));
        return new int[]{s,l};
    }
}