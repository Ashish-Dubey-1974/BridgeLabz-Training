using System;
class MatrixToSingleArray{
    static void Main(){
        int r=int.Parse(Console.ReadLine());
        int c=int.Parse(Console.ReadLine());
        int[,] m=new int[r,c];
        for(int i = 0; i < r; i++)
        {
            for(int j=0;j<c;j++) m[i,j]=int.Parse(Console.ReadLine());
        }
        int[] a=new int[r*c];
        int k=0;
        for(int i = 0; i < r; i++)
        {
            for(int j=0;j<c;j++) a[k++]=m[i,j];
        }
        for(int i=0;i<a.Length;i++) Console.WriteLine(a[i]);
    }
}