
using Ejecicio;

namespace Ejercicio.Test;

[TestClass]
public class CalculatorTest
{
    [TestMethod]
    public void CalculatePriceOfAList()
    {
        // Arrange
        var side = 5;
        var square = new SquareTie(side);
        var material = Material.Wood;
        var raidius = 5;
        var circle = new CircleTie(raidius);
        circle.Material = material;
        List<Tie> ties = new List<Tie> { square, circle };
        // Act
        var price = Calculator.CalculateTotalPrice(ties);
        var expectedPrice = 100 * side * side + 100 * Math.PI * raidius * raidius;

        // Assert
        Assert.AreEqual(expectedPrice, price);
    }

    [TestMethod]
    public void CalculateTotalAreaOfAList()
    {
        var side = 5;
        var square = new SquareTie(side);
        var material = Material.Wood;
        var raidius = 5;
        var circle = new CircleTie(raidius);
        circle.Material = material;
        List<Tie> ties = new List<Tie> { square, circle };
        // Act
        var area = Calculator.CalculateTotalArea(ties);
        var expectedArea =  side * side +  Math.PI * raidius * raidius;

        // Assert
        Assert.AreEqual(expectedArea, area);
    }
}