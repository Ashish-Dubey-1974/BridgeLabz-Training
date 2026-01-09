
class TaskNode
{
    public int TaskId;
    public string TaskName;
    public int Priority;
    public TaskNode Next;

    public TaskNode(int id, string name, int priority)
    {
        TaskId = id;
        TaskName = name;
        Priority = priority;
    }
}

class TaskScheduler
{
    private TaskNode head;

    public void AddTask(TaskNode node)
    {
        if (head == null)
        {
            head = node;
            node.Next = head;
            return;
        }

        TaskNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = node;
        node.Next = head;
    }
}
