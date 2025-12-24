using System;
class EmployeeBonus{
    static void Main(){
        double[] salary=new double[10];
        double[] years=new double[10];
        double totalBonus=0,totalOld=0,totalNew=0;
        for(int i=0;i<10;i++){
            salary[i]=double.Parse(Console.ReadLine());
            years[i]=double.Parse(Console.ReadLine());
            if(salary[i]<0||years[i]<0){
                i--;
                continue;
            }
        }
        for(int i=0;i<10;i++){
            totalOld+=salary[i];
            double b=years[i]>5?salary[i]*0.05:salary[i]*0.02;
            totalBonus+=b;
            totalNew+=salary[i]+b;
        }
        Console.WriteLine(totalBonus);
        Console.WriteLine(totalOld);
        Console.WriteLine(totalNew);
    }
}