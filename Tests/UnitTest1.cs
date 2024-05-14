namespace Tests;

[TestClass]
public class AreaTests
{
    [TestMethod]
    public void AreaConstructor()
    {
        Area area = new Area();
        Assert.IsNotNull(area);
    }
}