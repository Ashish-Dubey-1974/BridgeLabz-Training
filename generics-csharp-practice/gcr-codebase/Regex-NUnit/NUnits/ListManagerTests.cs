using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class ListManagerTests
{
    [Test]
    public void Add_Element_Test()
    {
        var list = new List<int>();
        new ListManager().AddElement(list, 10);
        Assert.AreEqual(1, list.Count);
    }
}