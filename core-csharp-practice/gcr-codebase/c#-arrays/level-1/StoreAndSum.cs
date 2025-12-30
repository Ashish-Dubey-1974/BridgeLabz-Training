using System;
class StoreAndSum{
    static void Main(){
        double[] a=new double[10];
        double total=0;
        int index=0;
        while(true){
            double v=double.Parse(Console.ReadLine());
            if(v<=0 || index==10) break;
            a[index++]=v;
        }
        for(int i=0;i<index;i++) total+=a[i];
        Console.WriteLine(total);
    }
}