using Prueba.Materials;
using Prueba.Shapes;

namespace Prueba.Tests;

[TestClass]
public class TileTest
{
    [TestMethod]
    public void TestCanCalculatePriceOfSquareStoneTile()
    {
        // Arrange
        Tile tile = new Tile(new Square(10), new Stone());
        
        // Act
        int price = tile.CalculatePrice();
        
        // Assert
        Assert.AreEqual(2000, price);
    }
    
    [TestMethod]
    public void TestCanCalculatePriceOfTriangleCeramicTile()
    {
        // Arrange
        Tile tile = new Tile(new Triangle(10, 5), new Ceramic());
        
        // Act
        int price = tile.CalculatePrice();
        
        // Assert
        Assert.AreEqual(250, price);
    }
}