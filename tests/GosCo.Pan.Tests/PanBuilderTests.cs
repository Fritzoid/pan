namespace GosCo.Pan.Tests;

[TestClass]
public sealed class PanBuilderTests
{
    [TestMethod]
    public void ConstructorTest()
    {
        var sut = new PanBuilder();
        Assert.IsNotNull(sut);
    }
}
