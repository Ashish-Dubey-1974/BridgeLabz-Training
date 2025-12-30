using System;
class RemainingChocolates
{
    public static void Main()
    {
        int chocolates = int.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine()); 
        int[] arr = FindRemainderAndQuotient(chocolates,students);
        Console.WriteLine($"Distributed : {arr[0]}\nRemaining : {arr[1]}");
    }
    static int[] FindRemainderAndQuotient(int num,int divisor)
    {
        return new int[]{num/divisor,num%divisor};
    }
}