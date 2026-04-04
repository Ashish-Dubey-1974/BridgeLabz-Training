
using System.Collections.Generic;

class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();

    public void Add(T c)
    {
        courses.Add(c);
    }

    public void EvaluateAll()
    {
        foreach (var c in courses)
            c.Evaluate();
    }
}
