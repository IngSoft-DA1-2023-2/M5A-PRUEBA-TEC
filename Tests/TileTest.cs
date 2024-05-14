using Baldoseria;

namespace Tests;

[TestClass]
public class TileTest
{
    [TestMethod]
    public void TileConstructor()
    {
        Square square = new Square(5);
        Material material = new Material("Ceramic", 10);
        Tile tile = new Tile(square, material);
        Assert.IsNotNull(tile);
    }
    
    [TestMethod]
    public void TileCalculatePrice()
    {
        Square square = new Square(5);
        Material material = new Material("Ceramic", 10);
        Tile tile = new Tile(square, material);
        tile.Price = 10;
        double result = tile.CalculatePrice();
        Assert.AreEqual(250, result);
    }
    
    [TestMethod]
    public void TileArea()
    {
        Square square = new Square(5);
        Material material = new Material("Ceramic", 10);
        Tile tile = new Tile(square, material);
        Assert.AreEqual(25, tile.Area);
    }
    
    [TestMethod]
    public void TilePrice()
    {
        Square square = new Square(5);
        Material material = new Material("Ceramic", 10);
        Tile tile = new Tile(square, material);
        Assert.AreEqual(250, tile.Price);
    }
    
    [TestMethod]
    public void TileShape()
    {
        Square square = new Square(5);
        Material material = new Material("Ceramic", 10);
        Tile tile = new Tile(square, material);
        Assert.AreEqual(square, tile.Shape);
    }
    
    [TestMethod]
    public void TileMaterial()
    {
        Square square = new Square(5);
        Material material = new Material("Ceramic", 10);
        Tile tile = new Tile(square, material);
        Assert.AreEqual(material, tile.Material);
    }
}