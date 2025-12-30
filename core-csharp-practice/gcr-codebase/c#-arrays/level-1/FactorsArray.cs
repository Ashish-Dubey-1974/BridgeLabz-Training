using System;
class FactorsArray{
    static void Main(){
        int n=int.Parse(Console.ReadLine());
        int max=10;
        int[] f=new int[max];
        int idx=0;
        for(int i=1;i<=n;i++){
            if(n%i==0){
                if(idx==max){
                    max*=2;
                    int[] t=new int[max];
                    for(int j=0;j<f.Length;j++) t[j]=f[j];
                    f=t;
                }
                f[idx++]=i;
            }
        }
        for(int i=0;i<idx;i++) Console.WriteLine(f[i]);
    }
}