using Prueba.Shapes;

namespace Prueba.Tests;

[TestClass]
public class ShapeTest
{
    [TestMethod]
    public void TestCanCalculateAreaOfSquare()
    {
        // Arrange
        IShape square = new Square(5);
        
        // Act
        int area = square.CalculateArea();
        
        // Assert
        Assert.AreEqual(25, area);
    }

    [TestMethod]
    public void TestCanCalculateAreaOfTriangle()
    {
        // Arrange
        IShape triangle = new Triangle(5, 10);
        
        // Act
        int area = triangle.CalculateArea();
        
        // Assert
        Assert.AreEqual(25, area);
    }
    
    [TestMethod]
    public void TestCannotCreateSquareWithNegativeWidth()
    {
        // Act
        var exception = Assert.ThrowsException<InvalidOperationException>(() => new Square(-5));
        
        // Assert
        Assert.AreEqual("Area must be positive", exception.Message);
    }
}