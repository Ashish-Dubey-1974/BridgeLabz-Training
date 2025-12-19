using System;
class HarryAge
{
    public static void Main(string[] Marks)
    {
        int physics = int.Parse(Marks[0]);
        int chemistry = int.Parse(Marks[1]);
        int maths = int.Parse(Marks[2]);
        float avg = (physics+chemistry+maths)/3f;
        Console.WriteLine($"Sam’s average mark in PCM is {avg}");
    }
}