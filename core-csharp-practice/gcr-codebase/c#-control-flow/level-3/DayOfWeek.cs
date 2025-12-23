using System;
class DayOfWeeks
{
    public static void Main()
    {
        // d0 = (d + x + 31m0 / 12) mod 7
        int m = Convert.ToInt16(Console.ReadLine());
        int d = Convert.ToInt16(Console.ReadLine());
        int y = Convert.ToInt16(Console.ReadLine());
        int y0 = y-(14-m)/12;
        int x = y0+y0/4-y0/100+y0/400;
        int m0 = m+12*((14-m)/12)-2;
        int d0 = (d+x+(31*m0)/12)%7;
        Console.WriteLine(d0);

    }
}