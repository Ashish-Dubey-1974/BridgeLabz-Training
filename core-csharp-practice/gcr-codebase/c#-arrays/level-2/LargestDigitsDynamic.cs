using System;
class LargestDigitsDynamic{
    static void Main(){
        int n=int.Parse(Console.ReadLine());
        int max=10,idx=0;
        int[] d=new int[max];
        while(n!=0){
            if(idx==max){
                max+=10;
                int[] t=new int[max];
                for(int i=0;i<d.Length;i++) t[i]=d[i];
                d=t;
            }
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