
using System;
class StudentVoteChecker
{
    public static void Main()
    {
        int[] age=new int[10];
        for(int i=0;i<10;i++)
        {
            age[i]=int.Parse(Console.ReadLine());
            Console.WriteLine(CanStudentVote(age[i]));
        }
    }
    static bool CanStudentVote(int age)
    {
        if(age<0)return false;
        return age>=18;
    }
}
