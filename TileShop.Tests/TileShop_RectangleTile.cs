namespace TileShop.Tests;

[TestClass]
public class TileShop_RectangleTile
{
    private static readonly Material ValidMaterial = new Material("concrete", 200);
    private const float ValidBase = 5;
    private const float ValidHeight = 8;
    
    [TestMethod]
    public void RectangleTile_BaseNotPositive_ShouldThrow()
    {
        const float nonPositiveBase = -1;

        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new RectangleTile(ValidMaterial, nonPositiveBase, ValidHeight));
    }
    
    [TestMethod]
    public void RectangleTile_HeightNotPositive_ShouldThrow()
    {
        const float nonPositiveHeight = -1;

        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new RectangleTile(ValidMaterial, ValidBase, nonPositiveHeight));
    }
    
    [TestMethod]
    public void RectangleTile_WithValidProperties_ShouldStoreProperties()
    {
        var tile = new RectangleTile(ValidMaterial, ValidBase, ValidHeight);
        
        Assert.AreEqual(ValidBase, tile.BaseInMeters);
        Assert.AreEqual(ValidHeight, tile.HeightInMeters);
        Assert.AreSame(ValidMaterial, tile.Material);
    }
    
    [DataRow(5, 3, 15)]
    [DataRow(8, 5, 40)]
    [DataRow(7, 23, 161)]
    [TestMethod]
    public void RectangleTile_CalculateAreaInSquareMeters_ShouldReturnCorrectValue(float baseInMeters, float heightInMeters, float expectedAreaInMeters)
    {
        var tile = new RectangleTile(ValidMaterial, baseInMeters, heightInMeters);
        Assert.AreEqual(expectedAreaInMeters, tile.CalculateAreaInSquareMeters());
    }
    
    [TestMethod]
    public void RectangleTile_CalculateCost_ShouldReturnCorrectValue()
    {
        const float materialCost = 400;
        const float b = 5;
        const float h = 8;
        const float expectedCost = b * h * materialCost;
        
        var material = new Material("Concrete", materialCost);
        var tile = new RectangleTile(material, b, h);
        
        Assert.AreEqual(expectedCost, tile.CalculateCost());
    }
}