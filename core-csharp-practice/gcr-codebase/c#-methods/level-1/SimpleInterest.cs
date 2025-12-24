using System;
class SimpleInterest
{
    public static void Main()
    {
        double p = double.Parse(Console.ReadLine());
        double r = double.Parse(Console.ReadLine());
        double t = double.Parse(Console.ReadLine());
        double SI = CalculateSI(p,r,t);
        Console.WriteLine($"The Simple Interest is {SI} for Principal {p}, Rate of Interest {r} and Time {t}");
    }
    static double CalculateSI(double p,double r,double t)
    {
        return (p*r*t)/100;
    }
}