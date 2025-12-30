using System;
class Table6to9
{
    static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        int[] r=new int[4];
        int k=0;
        for(int i=6;i<=9;i++) r[k++]=n*i;
        k=0;
        for(int i=6;i<=9;i++) Console.WriteLine(n+" * "+i+" = "+r[k++]);
    }
}