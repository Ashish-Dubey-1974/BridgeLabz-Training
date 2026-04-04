
class Program
{
    static void Main()
    {
        Course<ExamCourse> course = new Course<ExamCourse>();
        course.Add(new ExamCourse());
        course.EvaluateAll();
    }
}
