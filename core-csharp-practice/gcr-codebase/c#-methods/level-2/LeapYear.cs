
using System;
class LeapYear
{
    public static void Main()
    {
        int y=int.Parse(Console.ReadLine());
        Console.WriteLine(Check(y));
    }
    static bool Check(int y)
    {
        if(y<1582)return false;
        return (y%4==0 && y%100!=0)||y%400==0;
    }
}
