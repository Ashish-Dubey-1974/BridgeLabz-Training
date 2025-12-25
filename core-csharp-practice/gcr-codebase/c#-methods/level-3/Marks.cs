
using System;
class Marks
{
    public static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        Random r=new Random();
        for(int i=0;i<n;i++)
        {
            int p=r.Next(10,99);
            int c=r.Next(10,99);
            int m=r.Next(10,99);
            int t=p+c+m;
            double avg=t/3.0;
            Console.WriteLine(t+" "+Math.Round(avg,2));
        }
    }
}
