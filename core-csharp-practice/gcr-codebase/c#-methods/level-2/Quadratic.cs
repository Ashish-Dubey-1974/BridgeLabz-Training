
using System;
class Quadratic
{
    public static void Main()
    {
        double a=double.Parse(Console.ReadLine());
        double b=double.Parse(Console.ReadLine());
        double c=double.Parse(Console.ReadLine());
        double[] r=Roots(a,b,c);
        foreach(double x in r)Console.WriteLine(x);
    }
    static double[] Roots(double a,double b,double c)
    {
        double d=b*b-4*a*c;
        if(d<0)return new double[0];
        if(d==0)return new double[]{-b/(2*a)};
        return new double[]{(-b+Math.Sqrt(d))/(2*a),(-b-Math.Sqrt(d))/(2*a)};
    }
}
