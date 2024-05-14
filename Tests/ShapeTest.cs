using Baldoseria;

namespace Tests;

[TestClass]
public class ShapeTest
{
    [TestMethod]
    public void AreaConstructor()
    {
        Shape area = new Shape();
        Assert.IsNotNull(area);
    }
    
    [TestMethod]
    public void AreaCalculate()
    {
        Shape area = new Shape();
        area.Length = 5;
        area.Width = 10;
        double result = area.AreaCalculate();
        Assert.AreEqual(50, result);
    }
    
    [TestMethod]
    public void SquareAreaCalculate()
    {
        Square square = new Square(5);
        double result = square.AreaCalculate();
        Assert.AreEqual(25, result);
    }
    
    [TestMethod]
    public void RectangleAreaCalculate()
    {
        Rectangle rectangle = new Rectangle(5, 10);
        double result = rectangle.AreaCalculate();
        Assert.AreEqual(50, result);
    }
    
    [TestMethod]
    public void SideSquare()
    {
        Square square = new Square(5);
        Assert.AreEqual(5, square.Side);
    }
    
}