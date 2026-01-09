
class StudentNode
{
    public int RollNumber;
    public string Name;
    public int Age;
    public char Grade;
    public StudentNode Next;

    public StudentNode(int roll, string name, int age, char grade)
    {
        RollNumber = roll;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentLinkedList
{
    private StudentNode head;

    public void AddAtEnd(StudentNode node)
    {
        if (head == null) { head = node; return; }
        StudentNode temp = head;
        while (temp.Next != null)
            temp = temp.Next;
        temp.Next = node;
    }

    public StudentNode Search(int roll)
    {
        StudentNode temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == roll) return temp;
            temp = temp.Next;
        }
        return null;
    }
}
