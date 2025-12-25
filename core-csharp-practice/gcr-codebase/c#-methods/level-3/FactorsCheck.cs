
using System;
class FactorsCheck
{
    public static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        int[] f=Factors(n);
        int s=0,p=1;
        foreach(int x in f){s+=x;p*=x;}
        Console.WriteLine(s);
        Console.WriteLine(p);
    }
    static int[] Factors(int n)
    {
        int c=0;
        for(int i=1;i<=n;i++) if(n%i==0)c++;
        int[] a=new int[c];int k=0;
        for(int i=1;i<=n;i++) if(n%i==0)a[k++]=i;
        return a;
    }
}
