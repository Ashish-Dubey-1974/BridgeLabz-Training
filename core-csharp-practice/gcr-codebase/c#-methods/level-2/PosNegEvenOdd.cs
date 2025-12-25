
using System;
class PosNegEvenOdd
{
    public static void Main()
    {
        int[] a=new int[5];
        for(int i=0;i<5;i++)
        {
            a[i]=int.Parse(Console.ReadLine());
            if(IsPositive(a[i]))Console.WriteLine(IsEven(a[i])?"Even":"Odd");
            else Console.WriteLine("Negative");
        }
        int r=Compare(a[0],a[4]);
        Console.WriteLine(r);
    }
    static bool IsPositive(int n){
        return n>=0;
    }
    static bool IsEven(int n){
        return n%2==0;
    }
    static int Compare(int a,int b){
        if(a>b)return 1;
        if(a==b)return 0;
        return -1;
    }
}
