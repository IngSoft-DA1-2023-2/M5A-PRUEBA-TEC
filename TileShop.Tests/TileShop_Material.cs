namespace TileShop.Tests;

[TestClass]
public class TileShop_Material
{
    private const string ValidName = "Concrete";
    private const float ValidCost = 100;
    
    [TestMethod]
    public void Material_CostNegative_ShouldThrow()
    {
        const float negativeCost = -1;
        
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Material(ValidName, negativeCost));
    }
    
    [DataRow(ValidName, ValidCost)]
    [DataRow(ValidName, 0)]
    [DataRow(ValidName, 500)]
    [DataRow(ValidName, 30.52)]
    [TestMethod]
    public void RectangleTile_WithValidProperties_ShouldStoreProperties(string name, double cost)
    {
        var tile = new Material(name, cost);
        
        Assert.AreEqual(name, tile.Name);
        Assert.AreEqual(cost, tile.Cost);
    }
}