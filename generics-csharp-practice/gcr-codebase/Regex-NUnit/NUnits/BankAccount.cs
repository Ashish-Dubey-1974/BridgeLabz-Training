public class BankAccount
{
    private double balance;

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
            throw new ArgumentException("Insufficient funds");
        balance -= amount;
    }

    public double GetBalance() => balance;
}