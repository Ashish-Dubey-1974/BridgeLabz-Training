using System;
class SpringSeason
{
    public static void Main(string[] args)
    {
        if(check(args))Console.WriteLine("Its a Spring Season");
        else Console.WriteLine("Not a Spring Season");
    }
    static bool check(string[] args)
    {
        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);
        if(month == 3 && day<20)return false;
        if(month == 6 && day>20)return false;
        if(month >=3 && month <=6)return true;
        return false;
    }
}