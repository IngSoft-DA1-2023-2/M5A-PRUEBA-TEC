using Ejecicio;

namespace Ejercicio.Test;

[TestClass]
public class CircleTieTest
{
    [TestMethod]
    public void CreateCircle()
    {
        // Arrange
        var radius = 5;
        var circle = new CircleTie(radius);

        // Act
        var getRadius = circle.Radius;
        // Assert
        Assert.AreEqual(radius, getRadius);
    }

    [TestMethod]
    public void CalculateCircleArea()
    {
        // Arrange
        var radius = 5;
        var circle = new CircleTie(radius);

        // Act
        var area = circle.CalculateArea();
        var expectedArea = Math.PI * radius * radius;

        // Assert
        Assert.AreEqual(expectedArea, area);
    }

}
 
 