
using System.Collections.Generic;

interface IDepartment
{
    void AssignDepartment(string dept);
    string GetDepartmentDetails();
}

abstract class Employee
{
    private int employeeId;
    private string name;
    protected double baseSalary;

    public int EmployeeId { get { return employeeId; } }
    public string Name { get { return name; } }

    protected Employee(int id, string name, double salary)
    {
        this.employeeId = id;
        this.name = name;
        this.baseSalary = salary;
    }

    public abstract double CalculateSalary();

    public void DisplayDetails()
    {
        System.Console.WriteLine(EmployeeId + " " + Name + " Salary:" + CalculateSalary());
    }
}

class FullTimeEmployee : Employee, IDepartment
{
    private string department;

    public FullTimeEmployee(int id, string name, double salary) : base(id, name, salary) { }

    public override double CalculateSalary() => baseSalary;

    public void AssignDepartment(string dept) { department = dept; }
    public string GetDepartmentDetails() => department;
}

class PartTimeEmployee : Employee
{
    private int hoursWorked;

    public PartTimeEmployee(int id, string name, double rate, int hours) : base(id, name, rate)
    {
        hoursWorked = hours;
    }

    public override double CalculateSalary() => baseSalary * hoursWorked;
}
