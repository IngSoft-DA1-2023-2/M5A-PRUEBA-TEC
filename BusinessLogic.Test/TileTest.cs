namespace BusinessLogic.Test;

[TestClass]
public class TileTest
{
    [TestMethod]
    public void TestCanCreateSquareTile()
    {
        // Arrange
        const Material material = Material.Ceramic;
        const int width = 10;

        // Act
        var tile = new SquareTile(material, width);

        // Assert
        Assert.IsNotNull(tile);
    }

    [TestMethod]
    public void TestCanCreateRectangularTile()
    {
        // Arrange
        const Material material = Material.Stone;
        const int width = 10;
        const int length = 20;

        // Act
        var tile = new RectangularTile(material, width, length);

        // Assert
        Assert.IsNotNull(tile);
    }

    [TestMethod]
    public void TestCanCalculateAreaOfSquareTile()
    {
        // Arrange
        const Material material = Material.Ceramic;
        const int width = 10;
        const int expectedArea = 100;

        // Act
        var tile = new SquareTile(material, width);
        var area = tile.CalculateArea();

        // Assert
        Assert.AreEqual(expectedArea, area);
    }

    [TestMethod]
    public void TestCanCalculateAreaOfRectangularTile()
    {
        // Arrange
        const Material material = Material.Porcelain;
        const int width = 10;
        const int length = 20;
        const int expectedArea = 200;

        // Act
        var tile = new RectangularTile(material, width, length);
        var area = tile.CalculateArea();

        // Assert
        Assert.AreEqual(expectedArea, area);
    }
}