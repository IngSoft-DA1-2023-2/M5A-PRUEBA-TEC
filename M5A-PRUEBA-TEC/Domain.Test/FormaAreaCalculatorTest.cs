namespace Domain.Test;

[TestClass]
public class FormaAreaCalculatorTest
{
    [TestMethod]
    public void TestCalculateCircleArea()
    {
        var calculator = new FormaAreaCalculator();
        var result = FormaAreaCalculator.CalculateCircleArea(1);
        Assert.AreEqual(Math.PI, result);
    }
    
    [TestMethod]
    public void TestCalculateSquareArea()
    {
        var calculator = new FormaAreaCalculator();
        var result = FormaAreaCalculator.CalculateSquareArea(1);
        Assert.AreEqual(1, result);
    }
    
    [TestMethod]
    public void TestCalculateRectangleArea()
    {
        var calculator = new FormaAreaCalculator();
        var result = FormaAreaCalculator.CalculateRectangleArea(1, 1);
        Assert.AreEqual(1, result);
    }
}