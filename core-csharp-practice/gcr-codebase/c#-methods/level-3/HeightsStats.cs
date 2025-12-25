
using System;
class HeightsStats
{
    public static void Main()
    {
        int[] h=new int[11];
        Random r=new Random();
        for(int i=0;i<11;i++) h[i]=r.Next(150,251);
        Console.WriteLine(Shortest(h));
        Console.WriteLine(Tallest(h));
        Console.WriteLine(Mean(h));
    }
    static int Shortest(int[] a){
        int m=a[0];
        foreach(int x in a)
        m=Math.Min(m,x);
        return m;
    }
    static int Tallest(int[] a){
        int m=a[0];
        foreach(int x in a)
        m=Math.Max(m,x);
        return m;
    }
    static double Mean(int[] a){
        int s=0;
        foreach(int x in a)s+=x;
        return (double)s/a.Length;
    }
}
