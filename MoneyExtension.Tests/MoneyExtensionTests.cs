namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 277.89M;
        var cents = valor.ToCents();
        
        Assert.AreEqual(27789, cents);
    }
}

