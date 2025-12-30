using System;
class MultiplicationTable{
    static void Main(){
        int n=int.Parse(Console.ReadLine());
        int[] t=new int[10];
        for(int i=1;i<=10;i++) t[i-1]=n*i;
        for(int i=1;i<=10;i++) Console.WriteLine(n+" * "+i+" = "+t[i-1]);
    }
}