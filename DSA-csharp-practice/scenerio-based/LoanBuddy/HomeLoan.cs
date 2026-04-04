using System;

namespace LoanBuddy
{
    internal class HomeLoan : LoanApplication
    {
        public HomeLoan(Applicant applicant, int term)
            : base(applicant, term, 0.07 / 12)
        {
            loanType = "Home Loan";
        }

        public override bool ApproveLoan()
        {
            if (applicant.CreditScore >= 700 && applicant.Income >= 50000)
                SetLoanStatus(true);

            return loanStatus;
        }

        public override double CalculateEMI()
        {
            double P = applicant.LoanAmount;
            double R = interestRate;
            int N = term;

            return (P * R * Math.Pow(1 + R, N)) /(Math.Pow(1 + R, N) - 1);
        }
    }
}
