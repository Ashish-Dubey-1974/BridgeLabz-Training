using System;

namespace LoanBuddy
{
    class Program
    {
        static void Main()
        {
            Applicant user = new Applicant("Ashish", 720, 60000, 800000);

            LoanApplication loan = new HomeLoan(user, 240);

            if (loan.ApproveLoan())
            {
                Console.WriteLine("Loan Approved");
                Console.WriteLine($"Monthly EMI: ₹{loan.CalculateEMI()}");
            }
            else
            {
                Console.WriteLine("Loan Rejected");
            }

            loan.ShowLoanDetails();
        }
    }
}
