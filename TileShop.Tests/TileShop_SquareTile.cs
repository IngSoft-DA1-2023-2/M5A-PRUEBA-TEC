namespace TileShop.Tests;

[TestClass]
public class TileShop_SquareTile
{
    private static readonly Material ValidMaterial = new Material("concrete", 200);
    private const float ValidSideLength = 5;
    
    [TestMethod]
    public void RectangleTile_SideLengthNotPositive_ShouldThrow()
    {
        const int nonPositiveSideLength = -1;

        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new SquareTile(ValidMaterial, nonPositiveSideLength));
    }
    
    [TestMethod]
    public void RectangleTile_WithValidProperties_ShouldStoreProperties()
    {
        var tile = new SquareTile(ValidMaterial, ValidSideLength);
        
        Assert.AreEqual(ValidSideLength, tile.SideLengthInMeters);
        Assert.AreSame(ValidMaterial, tile.Material);
    }
    
    [TestMethod]
    public void RectangleTile_CalculateAreaInSquareMeters_ShouldReturnCorrectValue()
    {
        var tile = new SquareTile(ValidMaterial, ValidSideLength);
        const float expectedArea = ValidSideLength * ValidSideLength;
        
        Assert.AreEqual(expectedArea, tile.CalculateAreaInSquareMeters());
    }
}