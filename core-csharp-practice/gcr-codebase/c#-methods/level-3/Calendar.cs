
using System;
class Calendar
{
    public static void Main()
    {
        int m=int.Parse(Console.ReadLine());
        int y=int.Parse(Console.ReadLine());
        string[] mn={"","Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
        int[] d={0,31,28,31,30,31,30,31,31,30,31,30,31};
        if(IsLeap(y))d[2]=29;
        Console.WriteLine(mn[m]+" "+y);
    }
    static bool IsLeap(int y){
        return(y%4==0&&y%100!=0)||y%400==0;
    }
}
