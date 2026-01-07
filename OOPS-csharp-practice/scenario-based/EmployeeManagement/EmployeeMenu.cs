namespace EmployeeManagement
{
    sealed class EmployeeMenu
    {
        private IEmployee employeeService;
        public void DisplayMenu()
        {
            employeeService = new EMPLUtility();
            Console.WriteLine("\n-----------------Welcome To Employee Management Menu--------------------\n");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Employee is present  ?");
            int choice=int.Parse(Console.ReadLine());

            if(choice==1)
            {
                Employee emp = employeeService.AddEmployee();
                Console.WriteLine($"Employee Added Successfully: {emp}");
            }
            else if(choice==2)
            {
                Console.WriteLine("Enter Employee ID to check presence:");
                int empId = int.Parse(Console.ReadLine());
                bool isPresent = employeeService.IsEmployeePresent(empId);
                Console.WriteLine(isPresent ? "Employee is present." : "Employee is not present.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

        }
    }
}