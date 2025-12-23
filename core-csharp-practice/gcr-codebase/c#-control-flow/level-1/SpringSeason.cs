using System;
class SpringSeason
{
    public static void Main(string[] args)
    {
        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);

        if ((month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day <= 20))
            Console.WriteLine("Its a Spring Season");
        else Console.WriteLine("Not a Spring Season");
    }
}