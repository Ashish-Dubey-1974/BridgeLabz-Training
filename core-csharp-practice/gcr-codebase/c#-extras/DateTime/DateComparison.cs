
using System;

class DateComparison
{
    static void Main()
    {
        DateTime d1 = DateTime.Parse(Console.ReadLine());
        DateTime d2 = DateTime.Parse(Console.ReadLine());

        int result = DateTime.Compare(d1, d2);

        if (result < 0)Console.WriteLine("First date is earlier");
        else if (result > 0)Console.WriteLine("First date is later");
        else Console.WriteLine("Both dates are same");
    }
}
