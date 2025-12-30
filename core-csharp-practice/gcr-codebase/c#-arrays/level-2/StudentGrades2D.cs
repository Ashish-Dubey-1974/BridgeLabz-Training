using System;
class StudentGrades2D{
    static void Main(){
        int n=int.Parse(Console.ReadLine());
        int[][] m=new int[n][];
        double[] per=new double[n];
        char[] g=new char[n];
        for(int i=0;i<n;i++){
            m[i]=new int[3];
            m[i][0]=int.Parse(Console.ReadLine());
            m[i][1]=int.Parse(Console.ReadLine());
            m[i][2]=int.Parse(Console.ReadLine());
            if(m[i][0]<0||m[i][1]<0||m[i][2]<0){
                i--;
                continue;
            }
            per[i]=(m[i][0]+m[i][1]+m[i][2])/3.0;
            if(per[i]>=80) g[i]='A';
            else if(per[i]>=70) g[i]='B';
            else if(per[i]>=60) g[i]='C';
            else if(per[i]>=50) g[i]='D';
            else if(per[i]>=40) g[i]='E';
            else g[i]='R';
        }
        for(int i=0;i<n;i++) Console.WriteLine(m[i][0]+" "+m[i][1]+" "+m[i][2]+" "+per[i]+" "+g[i]);
    }
}