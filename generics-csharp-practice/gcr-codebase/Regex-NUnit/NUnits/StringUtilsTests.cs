using NUnit.Framework;

[TestFixture]
public class StringUtilsTests
{
    StringUtils utils = new StringUtils();

    [Test]
    public void Palindrome_Test()
    {
        Assert.IsTrue(utils.IsPalindrome("madam"));
    }
}