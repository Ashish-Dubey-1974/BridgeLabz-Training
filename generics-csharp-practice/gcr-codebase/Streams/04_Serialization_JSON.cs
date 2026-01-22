
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class SerializeDemo
{
    static void Main()
    {
        var list = new List<Employee>()
        {
            new Employee{Id=1,Name="Amit",Department="IT",Salary=50000}
        };

        File.WriteAllText("emp.json", JsonSerializer.Serialize(list));

        var data = JsonSerializer.Deserialize<List<Employee>>(File.ReadAllText("emp.json"));

        foreach (var e in data)
            Console.WriteLine(e.Name + " " + e.Salary);
    }
}
