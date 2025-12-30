using System;
class DigitFrequency{
static void Main(){
    int n=int.Parse(Console.ReadLine());
    int temp=n;
    int[] d=new int[20];
    int idx=0;
    while(temp!=0){
        d[idx++]=temp%10;
        temp/=10;
    }
    int[] f=new int[10];
    for(int i=0;i<idx;i++) f[d[i]]++;
    for(int i=0;i<10;i++) Console.WriteLine(i+" "+f[i]);
    }
}