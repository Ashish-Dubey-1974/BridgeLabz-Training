
using System;

class TemperatureConverter
{
    static double ToCelsius(double f)=> (f - 32) * 5 / 9;

    static double ToFahrenheit(double c)=>(c * 9 / 5) + 32;

    static void Main()
    {
        double val = double.Parse(Console.ReadLine());
        char ch = Console.ReadLine()[0];

        if (ch == 'C')
            Console.WriteLine(ToFahrenheit(val));
        else
            Console.WriteLine(ToCelsius(val));
    }
}
