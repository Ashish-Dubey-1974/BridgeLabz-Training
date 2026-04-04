
interface ILoanable
{
    void ApplyForLoan();
    double CalculateLoanEligibility();
}

abstract class BankAccount
{
    private int accountNumber;
    private string holderName;
    protected double balance;

    protected BankAccount(int acc, string name, double bal)
    {
        accountNumber = acc;
        holderName = name;
        balance = bal;
    }

    public void Deposit(double amount) { balance += amount; }
    public void Withdraw(double amount) { if (balance >= amount) balance -= amount; }

    public abstract double CalculateInterest();
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(int acc, string name, double bal) : base(acc, name, bal) { }
    public override double CalculateInterest() => balance * 0.04;
}

class CurrentAccount : BankAccount, ILoanable
{
    public CurrentAccount(int acc, string name, double bal) : base(acc, name, bal) { }
    public override double CalculateInterest() => 0;
    public void ApplyForLoan() { }
    public double CalculateLoanEligibility() => balance * 2;
}
