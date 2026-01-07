namespace EmployeeManagement
{
    public class Employee
    {
      
        int Id { get; set; }
        string Name { get; set; }
        string Position { get; set; }
        double Salary { get; set; }

        public Employee() { }

        public Employee(int id, string name, string position, double salary)
        {
            Id = id;
            Name = name;
            Position = position;
            Salary = salary;
        }

        public int GetId()
        {
            return Id;
        }


        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Position: {Position}, Salary: {Salary:C}";
        }
    }
}