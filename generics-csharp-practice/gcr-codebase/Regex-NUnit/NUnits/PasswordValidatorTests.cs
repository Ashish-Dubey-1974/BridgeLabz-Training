using NUnit.Framework;

[TestFixture]
public class PasswordValidatorTests
{
    [Test]
    public void ValidPassword_Test()
    {
        Assert.IsTrue(new PasswordValidator().IsValid("Test1234"));
    }
}