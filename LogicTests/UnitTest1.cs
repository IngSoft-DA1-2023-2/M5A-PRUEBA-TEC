namespace LogicTests;

[TestClass]
public class LogicTests
{
[TestMethod]
    public void CalculateIndividualTileArea()
    {
        // Arrange
        Material material = new Material("Stone");
        Shape shape = new Shape("Square", 2);
        Tile tile = new Tile(material, shape);
        double expectedArea = 4; // Since the side of the square is 2, the area should be 2*2 = 4

        // Act
        double actualArea = tile.CalculateArea();

        // Assert
        Assert.AreEqual(expectedArea, actualArea, "The calculated area is not as expected.");
    }
}