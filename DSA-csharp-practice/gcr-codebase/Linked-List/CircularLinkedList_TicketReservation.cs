
class TicketNode
{
    public int TicketId;
    public string CustomerName;
    public string MovieName;
    public TicketNode Next;

    public TicketNode(int id, string customer, string movie)
    {
        TicketId = id;
        CustomerName = customer;
        MovieName = movie;
    }
}
