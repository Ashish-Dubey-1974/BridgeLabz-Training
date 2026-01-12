using System;

namespace LoanBuddy
{
    internal class AutoLoan : LoanApplication
    {
        public AutoLoan(Applicant applicant, int term): base(applicant, term, 0.09 / 12)
        {
            loanType = "Auto Loan";
        }

        public override bool ApproveLoan()
        {
            if (applicant.CreditScore >= 650)
                SetLoanStatus(true);

            return loanStatus;
        }

        public override double CalculateEMI()
        {
            double P = applicant.LoanAmount;
            double R = interestRate;
            int N = term;

            return (P * R * Math.Pow(1 + R, N)) /
                   (Math.Pow(1 + R, N) - 1);
        }
    }
}
