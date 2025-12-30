using System;
class MeanHeight{
    static void Main(){
        double[] h=new double[11];
        double sum=0;
        for(int i=0;i<h.Length;i++){
            h[i]=double.Parse(Console.ReadLine());
            sum+=h[i];
        }
        Console.WriteLine(sum/11);
    }
}