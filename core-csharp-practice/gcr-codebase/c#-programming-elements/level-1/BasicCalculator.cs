using System;
class BasicCalculator
{
    public static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());

        double add = num1 + num2;
        double sub = num1 - num2;
        double mul = num1 * num2;
        double div = num1 / num2;

        Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {num1} and {num2} is {add}, {sub}, {mul}, and {div}");
    }
}