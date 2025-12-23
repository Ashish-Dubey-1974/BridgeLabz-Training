using System;
class BMIcalc
{
    static void Main()
    {
        double w = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine())/100;
        double bmi = w/(h*h);
        Console.WriteLine(bmi);
        if(bmi<18.5) Console.WriteLine("Underweight");
        else if(bmi<25) Console.WriteLine("Normal");
        else if(bmi<30) Console.WriteLine("Overweight");
        else Console.WriteLine("Obese");
    }
}