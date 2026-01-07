using System;
namespace EmployeeManagement
{
    sealed class EmployeeMenu
    {
        private IEmployee employeeService;
        public void DisplayMenu()
        {
            Console.WriteLine("\n-----------------Welcome To Employee Management Menu--------------------\n");
            while (true)
            {
                employeeService = new EMPLUtility();
                Console.WriteLine("\n-----------------Home Page--------------------\n");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Employee is present  ?");
                Console.WriteLine("3. Calculate Employee Wage");
                Console.WriteLine("4. Add PartTime Employee");
                Console.WriteLine("5. Display All Employees");
                Console.WriteLine("6. Exit");
                Console.WriteLine("------------------------------------------------------------");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Employee emp = employeeService.AddEmployee();
                        Console.WriteLine($"Employee Added Successfully: {emp}");
                        break;
                    case 2:
                        Console.WriteLine("Enter Employee ID to check presence:");
                        int empId = int.Parse(Console.ReadLine());
                        bool isPresent = employeeService.IsEmployeePresent(empId);
                        Console.WriteLine(isPresent ? "Employee is present." : "Employee is not present.");
                        break;
                    case 3:
                        Console.WriteLine("Enter Employee ID to calculate wage:");
                        int empIdWage = int.Parse(Console.ReadLine());
                        double wage = employeeService.CalculateWage(empIdWage);
                        Console.WriteLine($"Calculated Wage: {wage}");
                        break;
                    case 4:
                        employeeService.AddPartTimeEmployee();
                        break;
                    case 5:
                        employeeService.DisplayAllEmployees();
                        break;
                    case 6:
                        Console.WriteLine("Exiting the menu. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

        }
    }
}