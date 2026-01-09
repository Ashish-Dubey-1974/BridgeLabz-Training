
class ProcessNode
{
    public int ProcessId;
    public int BurstTime;
    public ProcessNode Next;

    public ProcessNode(int id, int burst)
    {
        ProcessId = id;
        BurstTime = burst;
    }
}
