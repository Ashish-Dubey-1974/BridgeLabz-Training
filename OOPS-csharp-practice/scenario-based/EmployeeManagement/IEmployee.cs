namespace EmployeeManagement{
    internal interface IEmployee
    {
        Employee AddEmployee();
        bool IsEmployeePresent(int empId);

    }
}