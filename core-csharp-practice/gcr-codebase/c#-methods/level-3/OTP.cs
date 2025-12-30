
using System;
class OTP
{
    public static void Main()
    {
        int[] a=new int[10];
        for(int i=0;i<10;i++) a[i]=Gen();
        Console.WriteLine(Unique(a));
    }
    static int Gen(){
        return new Random().Next(100000,999999);
    }
    static bool Unique(int[] a)
    {
        for(int i=0;i<a.Length;i++)
            for(int j=i+1;j<a.Length;j++)
                if(a[i]==a[j])return false;
        return true;
    }
}
