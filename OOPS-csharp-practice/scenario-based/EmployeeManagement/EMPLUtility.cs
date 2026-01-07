namespace EmployeeManagement{
    public class  EMPLUtility:IEmployee
    {
        static Employee[] employees = new Employee[100];
        static int count = 0;
        private Employee employee;

        //------------------------------Add some Employee Data-------------------------
        static EMPLUtility()
        {
            employees[0] = new Employee(1, "Hemant", "Software Engineer", 75000);
             employees[1] = new Employee(2, "Ashish", "Project Manager", 90000);
             employees[2] =   new Employee(3, "Pushpendra ", "QA Analyst", 60000);
            count = 3;
        }






        //-------------------------Add IEmployee Method-------------------------
        public Employee AddEmployee()
        {
            if(count>=employees.Length)
            {
                Console.WriteLine("Employee limit reached. Cannot add more employees.");
                return null;
            }
            Console.WriteLine("Adding a new employee...");
            Console.Write("Enter employee ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter employee Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter employee Position: ");
            string position = Console.ReadLine();
            Console.Write("Enter employee Salary: ");
            double salary = double.Parse(Console.ReadLine());

            employee = new Employee(id,name,position,salary);
            employees[count++] = employee;
            return employee;
        }


        //-----------------------------------------Check IEmployee Method-------------------------
        public bool IsEmployeePresent(int empId)
        {
            for(int i=0;i<count;i++)if(employees[i].GetId()==empId)return true;            
            return false;
        }

    }
}