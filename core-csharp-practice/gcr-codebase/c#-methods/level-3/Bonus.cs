
using System;
class Bonus
{
    public static void Main()
    {
        Random r=new Random();
        double total=0;
        for(int i=0;i<10;i++)
        {
            double sal=r.Next(10000,99999);
            int y=r.Next(1,11);
            double b=y>5?sal*0.05:sal*0.02;
            total+=b;
        }
        Console.WriteLine(total);
    }
}
