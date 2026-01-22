
namespace AmbulanceRoute
{
    internal class Unit
    {
        public string Name;
        public bool IsAvailable;
        public Unit Next;

        public Unit(string name, bool available = true)
        {
            Name = name;
            IsAvailable = available;
            Next = null;
        }
    }
}
