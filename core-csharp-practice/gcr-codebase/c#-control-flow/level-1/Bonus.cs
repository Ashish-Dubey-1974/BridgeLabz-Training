using System;
class Bonus
{
    public static void Main()
    {
        double salary = double.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        if (year > 5) Console.WriteLine(salary * 0.05);
        else Console.WriteLine(0);
    }
}