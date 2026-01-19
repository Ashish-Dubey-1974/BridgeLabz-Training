namespace ExamProctor
{
    internal class Program
    {
        static void Main()
        {
            Exam exam = new Exam();
            Console.WriteLine("This is Proctoring System Please be Care While Exam...\n");
            Console.WriteLine("---------Exam Starts---------\n");
            exam.Starts();
        }
    }
}