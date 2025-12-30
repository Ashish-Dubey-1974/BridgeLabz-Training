using System;
class OddEvenArrays{
    static void Main(){
        int n=int.Parse(Console.ReadLine());
        if(n<=0) return;
        int[] odd=new int[n/2+1];
        int[] even=new int[n/2+1];
        int oi=0,ei=0;
        for(int i=1;i<=n;i++){
            if(i%2==0) even[ei++]=i;
            else odd[oi++]=i;
        }
        for(int i=0;i<oi;i++) Console.WriteLine(odd[i]);
        for(int i=0;i<ei;i++) Console.WriteLine(even[i]);
    }
}