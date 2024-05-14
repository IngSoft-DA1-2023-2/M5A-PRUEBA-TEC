using Logic;

namespace LogicTests;

[TestClass]
public class LogicTests
{
[TestMethod]
    public void CreateTileWithValidData()
    {
        // Arrange
        Material material =  new Material("Steel", 10);
        int[] dimensions = new int[1];
        dimensions[0] = 8;
        Shape shape = new Shape("Square", dimensions);

        Tile tile = new Tile(material, shape);
        
        // Assert
        Assert.AreEqual(tile.Material.MatirialName, "Steel");
        Assert.AreEqual(tile.Shape.ShapeName, "Square");
        Assert.AreEqual(tile.Cost, 640);
    }
}