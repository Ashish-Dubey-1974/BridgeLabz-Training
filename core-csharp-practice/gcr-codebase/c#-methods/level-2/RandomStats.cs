
using System;
class RandomStats
{
    public static void Main()
    {
        int[] a=Generate4DigitRandomArray(5);
        double[] r=FindAverageMinMax(a);
        foreach(int x in a)Console.Write(x+" ");
        Console.WriteLine();
        Console.WriteLine(r[0]+" "+r[1]+" "+r[2]);
    }
    static int[] Generate4DigitRandomArray(int s)
    {
        int[] a=new int[s];
        Random r=new Random();
        for(int i=0;i<s;i++)a[i]=r.Next(1000,9999);
        return a;
    }
    static double[] FindAverageMinMax(int[] a)
    {
        int min=a[0],max=a[0],sum=0;
        foreach(int x in a){sum+=x;min=Math.Min(min,x);max=Math.Max(max,x);}
        return new double[]{(double)sum/a.Length,min,max};
    }
}
