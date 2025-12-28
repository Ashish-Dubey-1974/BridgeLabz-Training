
using System;

class TimeZonesDemo
{
    static void Main()
    {
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;

        TimeZoneInfo gmt = TimeZoneInfo.Utc;
        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        Console.WriteLine("GMT : " + TimeZoneInfo.ConvertTime(utcNow, gmt));
        Console.WriteLine("IST : " + TimeZoneInfo.ConvertTime(utcNow, ist));
        Console.WriteLine("PST : " + TimeZoneInfo.ConvertTime(utcNow, pst));
    }
}
