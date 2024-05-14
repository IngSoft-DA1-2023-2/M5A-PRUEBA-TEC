namespace TileShop.Tests;

[TestClass]
public class TileShop_CircleTile
{
    private static readonly Material ValidMaterial = new Material("concrete", 200);
    private const float ValidRadius = 5;
    
    [TestMethod]
    public void CircleTile_RadiusNotPositive_ShouldThrow()
    {
        const float nonPositiveRadius = -1;

        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CircleTile(ValidMaterial, nonPositiveRadius));
    }
    
    [TestMethod]
    public void CircleTile_WithValidProperties_ShouldStoreProperties()
    {
        var tile = new CircleTile(ValidMaterial, ValidRadius);
        
        Assert.AreEqual(ValidRadius, tile.RadiusInMeters);
        Assert.AreSame(ValidMaterial, tile.Material);
    }
    
    [TestMethod]
    public void CircleTile_CalculateAreaInSquareMeters_ShouldReturnCorrectValue()
    {
        const float radius = 5;
        const float expectedArea = MathF.PI * radius * radius;
        var tile = new CircleTile(ValidMaterial, ValidRadius);
        
        Assert.AreEqual(expectedArea, tile.CalculateAreaInSquareMeters());
    }
    
    [TestMethod]
    public void CircleTile_CalculateCost_ShouldReturnCorrectValue()
    {
        const double materialCost = 400;
        const float radius = 5;
        const double expectedCost = MathF.PI * radius * radius * materialCost;
        
        var material = new Material("Concrete", materialCost);
        var tile = new CircleTile(material, radius);
        
        Assert.AreEqual(expectedCost, tile.CalculateCost());
    }
}