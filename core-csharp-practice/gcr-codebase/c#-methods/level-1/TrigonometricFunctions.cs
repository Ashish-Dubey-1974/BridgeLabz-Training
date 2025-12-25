using System;
class TrigonometricFunctions
{
    public static void Main()
    {
        double angle = double.Parse(Console.ReadLine());
        double[] arr = CalculateTrigonometricFunctions(angle);
        Console.WriteLine($"Sine : {arr[0]}\nCosine : {arr[1]}\nTangent : {arr[2]}");
    }
    static double[] CalculateTrigonometricFunctions(double angle)
    {
        double rad = angle * Math.PI / 180;
        return new double[] { Math.Sin(rad), Math.Cos(rad), Math.Tan(rad) };
    }
}
