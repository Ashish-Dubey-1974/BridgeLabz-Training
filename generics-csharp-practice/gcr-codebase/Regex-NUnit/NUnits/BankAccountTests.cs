using NUnit.Framework;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Deposit_Test()
    {
        var acc = new BankAccount();
        acc.Deposit(1000);
        Assert.AreEqual(1000, acc.GetBalance());
    }
}