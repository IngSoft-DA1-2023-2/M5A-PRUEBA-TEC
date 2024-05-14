using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test;

[TestClass]
public class SquareTileTest
{
    [TestMethod]
    [DataRow(Material.Stone,2,4)]
    [DataRow(Material.Ceramic,3,9)]
    public void CreateSquareTile(Material mat, float side, float expectedArea)
    {
        var squareTile = new SquareTile(mat, side);
        Assert.AreEqual(expectedArea, squareTile.Area);
    }
    
    [TestMethod]
    [DataRow(Material.Stone,2,60)]
    [DataRow(Material.Ceramic,3,90)]
    public void CalculateTilePriceTest(Material mat, float side, float expectedPrice)
    {
        var squareTile = new SquareTile(mat, side);
        Assert.AreEqual(expectedPrice, squareTile.Price);
    }
}