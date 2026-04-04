namespace LoanBuddy
{
    internal interface IApprovable
    {
        bool ApproveLoan();
        double CalculateEMI();
    }
}
