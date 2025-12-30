using System;
class calculator
{
    public static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        String op = Console.ReadLine();
        switch (op)
        {
            case "+":
            Console.WriteLine(num1+num2);
            break;
            case "-":
            Console.WriteLine(num1-num2);
            break;
            case "*":
            Console.WriteLine(num1*num2);
            break;
            case "/":
            Console.WriteLine(num1/num2);
            break;

            default:
            Console.WriteLine("op is invalid :");
            break;
        }
    }
}