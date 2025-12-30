using System;
class FindRemainderAndQuotient
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int divisor = int.Parse(Console.ReadLine()); 
        int[] arr = FindRemainderAndQuotient(num,divisor);
        Console.WriteLine($"Quotient : {arr[0]}\nRemainder : {arr[1]}");
    }
    static int[] FindRemainderAndQuotient(int num,int divisor)
    {
        return new int[]{num/divisor,num%divisor};
    }
}