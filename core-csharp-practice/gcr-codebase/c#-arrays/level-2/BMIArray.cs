using System;
class BMIArray{
    static void Main(){
        int n=int.Parse(Console.ReadLine());
        double[] w=new double[n];
        double[] h=new double[n];
        double[] bmi=new double[n];
        string[] s=new string[n];
        for(int i=0;i<n;i++){
            w[i]=double.Parse(Console.ReadLine());
            h[i]=double.Parse(Console.ReadLine());
            bmi[i]=w[i]/((h[i]/100)*(h[i]/100));
            if(bmi[i]<18.5) s[i]="Underweight";
            else if(bmi[i]<25) s[i]="Normal";
            else if(bmi[i]<30) s[i]="Overweight";
            else s[i]="Obese";
        }
        for(int i=0;i<n;i++) Console.WriteLine(h[i]+" "+w[i]+" "+bmi[i]+" "+s[i]);
    }
}