using System;
class BMI2DArray{
    static void Main(){
        int n=int.Parse(Console.ReadLine());
        double[][] p=new double[n][];
        string[] s=new string[n];
        for(int i=0;i<n;i++){
            p[i]=new double[3];
            p[i][0]=double.Parse(Console.ReadLine());
            p[i][1]=double.Parse(Console.ReadLine());
            p[i][2]=p[i][1]/((p[i][0]/100)*(p[i][0]/100));
            if(p[i][2]<18.5) s[i]="Underweight";
            else if(p[i][2]<25) s[i]="Normal";
            else if(p[i][2]<30) s[i]="Overweight";
            else s[i]="Obese";
        }
        for(int i=0;i<n;i++) Console.WriteLine(p[i][0]+" "+p[i][1]+" "+p[i][2]+" "+s[i]);
    }
}