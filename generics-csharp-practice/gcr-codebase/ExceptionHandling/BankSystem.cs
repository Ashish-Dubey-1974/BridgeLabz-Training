
using System;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string msg) : base(msg) { }
}

class BankAccount
{
    double balance = 5000;

    public void Withdraw(double amount)
    {
        if (amount < 0)
            throw new ArgumentException("Invalid amount!");

        if (amount > balance)
            throw new InsufficientFundsException("Insufficient balance!");

        balance -= amount;
        Console.WriteLine("Withdrawal successful, new balance: " + balance);
    }
}

class BankDemo
{
    static void Main()
    {
        BankAccount acc = new BankAccount();

        try
        {
            Console.Write("Enter withdrawal amount: ");
            double amt = double.Parse(Console.ReadLine());
            acc.Withdraw(amt);
        }
        catch (InsufficientFundsException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
