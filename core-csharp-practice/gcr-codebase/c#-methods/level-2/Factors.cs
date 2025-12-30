
using System;
class Factors
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = FindFactors(n);
        int sum = Sum(arr);
        int product = Product(arr);
        int sqSum = SumOfSquares(arr);

        foreach(int x in arr) Console.Write(x+" ");
        Console.WriteLine("\nSum : "+sum);
        Console.WriteLine("Product : "+product);
        Console.WriteLine("Sum of Squares : "+sqSum);
    }
    static int[] FindFactors(int n)
    {
        int count=0;
        for(int i=1;i<=n;i++) if(n%i==0) count++;
        int[] arr=new int[count];
        int k=0;
        for(int i=1;i<=n;i++) if(n%i==0) arr[k++]=i;
        return arr;
    }
    static int Sum(int[] a){
        int s=0;
        foreach(int x in a)s+=x;
        return s;
    }
    static int Product(int[] a){
        int p=1;
        foreach(int x in a)p*=x;
        return p;
    }
    static int SumOfSquares(int[] a){
        int s=0;
        foreach(int x in a)s+=(int)Math.Pow(x,2);
        return s;
    }
}
