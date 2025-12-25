
using System;
class RecursiveSum
{
    public static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        if(n<=0)return;
        int r1=RecSum(n);
        int r2=Formula(n);
        Console.WriteLine(r1);
        Console.WriteLine(r2);
        Console.WriteLine(r1==r2);
    }
    static int RecSum(int n){
        if(n==1)return 1;
        return n+RecSum(n-1);
    }
    static int Formula(int n){
        return n*(n+1)/2;
    }
}
