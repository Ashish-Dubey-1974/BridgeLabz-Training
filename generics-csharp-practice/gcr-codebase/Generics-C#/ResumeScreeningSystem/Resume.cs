
using System.Collections.Generic;

class Resume<T> where T : JobRole, new()
{
    private List<T> resumes = new List<T>();

    public void Add()
    {
        resumes.Add(new T());
    }

    public void Screen()
    {
        foreach (var r in resumes)
            r.Process();
    }
}
