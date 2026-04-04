
using System;
using System.IO;

class Program {
    static void Main() {
        string[] data = {
            "ID,Name,Department,Salary",
            "1,Rahul,IT,50000",
            "2,Amit,HR,40000",
            "3,Neha,Finance,45000",
            "4,Pooja,IT,60000",
            "5,Karan,Sales,42000"
        };
        File.WriteAllLines("employees.csv", data);
        Console.WriteLine("CSV created successfully");
    }
}
