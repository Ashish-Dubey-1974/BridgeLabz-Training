using System;
class LargestDigits{
    static void Main(){
        int n=int.Parse(Console.ReadLine());
        int[] d=new int[10];
        int idx=0;
        while(n!=0 && idx<10){
            d[idx++]=n%10;
            n/=10;
        }
        int l=0,s=0;
        for(int i=0;i<idx;i++){
            if(d[i]>l){
                s=l;
                l=d[i];
            }
            else if(d[i]>s && d[i]!=l) s=d[i];
        }
    Console.WriteLine(l);
    Console.WriteLine(s);
    }
}