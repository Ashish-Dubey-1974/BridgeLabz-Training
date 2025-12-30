using System;
class CanVote
{
    public static void Main()
    {
        int[] ages = new int[10];
        for(int i=0;i<ages.Length;i++)ages[i] = int.Parse(Console.ReadLine());
        foreach(int age in ages)
        {
            if(age<0)Console.WriteLine("Invalid age");
            else if(age<18)Console.WriteLine($"The student with the age {age} can not vote");
            else Console.WriteLine($"The student with the age {age} can vote");
        }
    }
}