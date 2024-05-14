using Baldoseria;

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
    
    [TestMethod]
    public void SquareAreaCalculate()
    {
        Area area = new Area();
        double result = area.SquareAreaCalculate(5);
        Assert.AreEqual(25, result);
    }
    
    [TestMethod]
    public void RectangleAreaCalculate()
    {
        Area area = new Area();
        double result = area.RectangleAreaCalculate(5, 10);
        Assert.AreEqual(50, result);
    }
}