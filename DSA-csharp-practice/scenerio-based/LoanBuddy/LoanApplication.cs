using System;

namespace LoanBuddy
{
    internal abstract class LoanApplication : IApprovable
    {
        protected Applicant applicant;
        protected int term;
        protected double interestRate;
        protected string loanType;
        protected bool loanStatus;

        protected LoanApplication(Applicant applicant, int term, double interestRate)
        {
            this.applicant = applicant;
            this.term = term;
            this.interestRate = interestRate;
        }

        protected void SetLoanStatus(bool status)
        {
            loanStatus = status;
        }

        public abstract bool ApproveLoan();
        public abstract double CalculateEMI();

        public void ShowLoanDetails()
        {
            Console.WriteLine($"Loan Type: {loanType}");
            Console.WriteLine($"Applicant: {applicant.Name}");
            Console.WriteLine($"Loan Amount: ₹{applicant.LoanAmount}");
            Console.WriteLine($"Loan Status: {(loanStatus ? "Approved" : "Rejected")}");
        }
    }
}
