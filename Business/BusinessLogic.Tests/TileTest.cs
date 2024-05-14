namespace BusinessLogic.Tests;

[TestClass]
public class TileTest
{
    [TestMethod]
    public void CreateTile()
    {
        Tile tile = new Tile();
        Assert.IsNotNull(tile);
    }
    
    [TestMethod]
    public void CreateTileWithParameters()
    {
        Shape expectedShape = Shape.Square;
        Material expectedMaterial = Material.Ceramic;
        
        Tile tile = new Tile(expectedShape, expectedMaterial);
        
        Assert.IsNotNull(tile);
        Assert.AreEqual(expectedShape, tile.Shape);
        Assert.AreEqual(expectedMaterial, tile.Material);
    }
    
    [TestMethod]
    public void CreateTileWithAllAttributes()
    {
        Shape expectedShape = Shape.Square;
        Material expectedMaterial = Material.Ceramic;
        
        Tile tile = new Tile()
        {
            Shape = expectedShape,
            Material = expectedMaterial,
        };
        
        Assert.AreEqual(expectedShape, tile.Shape);
        Assert.AreEqual(expectedMaterial, tile.Material);
    }
    
   [TestMethod]
    public void InvalidShape()
    {
        Shape invalidShape = (Shape) 5;
        Material expectedMaterial = Material.Ceramic;
        var Exception = Assert.ThrowsException<ArgumentException>(() =>
        {
            Tile tile = new Tile(invalidShape, expectedMaterial);
        });
        Assert.AreEqual("Invalid shape", Exception.Message);
    }

    [TestMethod]
    public void InvalidMaterial()
    {
        Shape expectedShape = Shape.Rectangle;
        Material invalidMaterial = (Material) 5;
        var Exception = Assert.ThrowsException<ArgumentException>(() =>
        {
            Tile tile = new Tile(expectedShape , invalidMaterial);
        });
        Assert.AreEqual("Invalid material", Exception.Message);
    }
    
    [TestMethod]
    public void CalculatePrice()
    {
        Shape expectedShape = Shape.Rectangle;
        Material expectedMaterial = Material.Ceramic;
        int quantity = 1;
        Tile tile = new Tile(expectedShape, expectedMaterial);
        double expectedPrice = 10;
        double actualPrice = tile.CalculateTilePrice(quantity, expectedMaterial);
        Assert.AreEqual(expectedPrice, actualPrice);
    }
    
    [TestMethod]
    public void CalculateTotalArea()
    {
        Shape expectedShape = Shape.Rectangle;
        Material expectedMaterial = Material.Ceramic;
        int quantity = 1;
        Tile tile = new Tile(expectedShape, expectedMaterial);
        double expectedArea = 200;
        double actualArea = tile.CalculateArea(quantity, (Shape)expectedShape);
        Assert.AreEqual(expectedArea, actualArea);
    }
}