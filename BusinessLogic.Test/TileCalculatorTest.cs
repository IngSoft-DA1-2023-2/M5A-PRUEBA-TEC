namespace BusinessLogic.Test;

[TestClass]
public class TileCalculatorTest
{
    [TestMethod]
    public void TestCanCalculateTotalPrice()
    {
        // Arrange
        const Material material = Material.Ceramic;
        const double width = 10;
        const double area = 100;
        const double price = 2;
        var tiles = new List<Tile>
        {
            new SquareTile(material, width),
            new SquareTile(material, width)
        };

        var materialPrices = new Dictionary<Material, double>
        {
            { Material.Ceramic, price }
        };
        var calculator = new TileCalculator(materialPrices);

        // Act
        var totalPrice = calculator.CalculateTotalPrice(tiles);

        // Assert
        Assert.AreEqual(tiles.Count * price * area, totalPrice);
    }

    [TestMethod]
    public void TestCantCalculateTotalPriceWithUnknownMaterial()
    {
        // Arrange
        const Material material = Material.Ceramic;
        const double width = 10;
        var tiles = new List<Tile>
        {
            new SquareTile(material, width)
        };

        var materialPrices = new Dictionary<Material, double>();
        var calculator = new TileCalculator(materialPrices);

        // Act
        var exception = Assert.ThrowsException<KeyNotFoundException>(() => calculator.CalculateTotalPrice(tiles));

        // Assert
        Assert.AreEqual("Unknown material price.", exception.Message);
    }
    
    [TestMethod]
    public void TestCanCalculateTotalArea()
    {
        // Arrange
        const Material material = Material.Ceramic;
        const double width = 10;
        const double area = 100;
        var tiles = new List<Tile>
        {
            new SquareTile(material, width),
            new SquareTile(material, width)
        };

        // Act
        var totalArea = TileCalculator.CalculateTotalArea(tiles);

        // Assert
        Assert.AreEqual(tiles.Count * area, totalArea);
    }
}