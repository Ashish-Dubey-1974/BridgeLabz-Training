using System;
class StudentGrades{
    static void Main(){
        int n=int.Parse(Console.ReadLine());
        int[] p=new int[n];
        int[] c=new int[n];
        int[] m=new int[n];
        double[] per=new double[n];
        char[] g=new char[n];
        for(int i=0;i<n;i++){
            p[i]=int.Parse(Console.ReadLine());
            c[i]=int.Parse(Console.ReadLine());
            m[i]=int.Parse(Console.ReadLine());
            if(p[i]<0||c[i]<0||m[i]<0){
                i--;
                continue;
            }
            per[i]=(p[i]+c[i]+m[i])/3.0;
            if(per[i]>=80) g[i]='A';
            else if(per[i]>=70) g[i]='B';
            else if(per[i]>=60) g[i]='C';
            else if(per[i]>=50) g[i]='D';
            else if(per[i]>=40) g[i]='E';
            else g[i]='R';
        }
        for(int i=0;i<n;i++) Console.WriteLine(p[i]+" "+c[i]+" "+m[i]+" "+per[i]+" "+g[i]);
    }
}