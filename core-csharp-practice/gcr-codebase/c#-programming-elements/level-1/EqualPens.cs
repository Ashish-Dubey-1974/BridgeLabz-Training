using System;
class EqualPens
{
    public static void Main()
    {
        int pen = 14;
        int d = 3;
        int equallyDivided = 14/3;
        int remaining = 14%3;
        Console.WriteLine($"The Pen Per Student is {equallyDivided} and the remaining pen not distributed is {remaining}");
    }
}