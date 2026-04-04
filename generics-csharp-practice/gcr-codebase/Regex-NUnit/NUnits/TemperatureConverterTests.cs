using NUnit.Framework;

[Test]
public void CelsiusToFahrenheit_Test()
{
    var t = new TemperatureConverter();
    Assert.AreEqual(32, t.CelsiusToFahrenheit(0));
}