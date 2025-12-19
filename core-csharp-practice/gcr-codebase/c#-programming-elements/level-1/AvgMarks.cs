using System;
class AvgMarks
{
    public static void Main(string[] Marks)
    {
        int physics=0,chemistry=0,maths=0;
        if (Marks.Length != 3)
        {
            Console.WriteLine("Enter PCM Marks....");
            physics = int.Parse(Console.ReadLine());
            chemistry = int.Parse(Console.ReadLine());
            maths = int.Parse(Console.ReadLine());
        }
        else
        {
            physics = int.Parse(Marks[0]);
            chemistry = int.Parse(Marks[1]);
            maths = int.Parse(Marks[2]);
        }
        float avg = (physics+chemistry+maths)/3f;
        Console.WriteLine($"Sam’s average mark in PCM is {avg}");
    }
}