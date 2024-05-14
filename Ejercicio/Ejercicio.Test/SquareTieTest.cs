using Ejecicio;

namespace Ejercicio.Test;

[TestClass]
public class SquareTieTest
{
    [TestMethod]
    public void createSquare()
    {
        // Arrange
        var side = 5;
        var square = new SquareTie(side);

        // Act
        var getSide = square.Side;
        // Assert
        Assert.AreEqual(side, getSide);
    }
    
    [TestMethod]
    public void CalculateSquareArea()
    {
        // Arrange
        var side = 5;
        var square = new SquareTie(side);

        // Act
        var area = square.CalculateArea();
        var expectedArea = side * side;

        // Assert
        Assert.AreEqual(expectedArea, area);
    }

}