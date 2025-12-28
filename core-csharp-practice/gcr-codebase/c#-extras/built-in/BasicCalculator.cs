
using System;

class BasicCalculator
{
    static int Add(int a, int b) => a + b;
    static int Sub(int a, int b) => a - b;
    static int Mul(int a, int b) => a * b;
    static int Div(int a, int b) => a / b;

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        char op = Console.ReadLine()[0];

        if (op == '+') Console.WriteLine(Add(a, b));
        else if (op == '-') Console.WriteLine(Sub(a, b));
        else if (op == '*') Console.WriteLine(Mul(a, b));
        else if (op == '/') Console.WriteLine(Div(a, b));
    }
}
