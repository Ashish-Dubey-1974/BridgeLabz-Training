
class UserNode
{
    public int UserId;
    public string Name;
    public UserNode Next;

    public UserNode(int id, string name)
    {
        UserId = id;
        Name = name;
    }
}
