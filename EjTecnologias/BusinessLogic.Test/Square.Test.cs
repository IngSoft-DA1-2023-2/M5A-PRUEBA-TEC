using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test;

[TestClass]
public class Square_Test
{
    [TestMethod]
    public void ShouldCreateNewSquareShape()
    {
        var square = new Square();
        Assert.IsNotNull(square);
    }
    
    
    [TestMethod]
    public void ShouldSetSquareSide()
    {
        var square = new Square();
        square.Side = 5;
        Assert.AreEqual(5, square.Side);
    }
    
    [TestMethod]
    public void ShouldCalculateSquareArea()
    {
        var square = new Square();
        square.Side = 5;
        Assert.AreEqual(25, square.Area());
    }

    [TestMethod]
    public void ShouldSetMaterial()
    {
        var square = new Square();
        square.Material = "Wood";
        Assert.AreEqual("Wood", square.Material);
    }

    [TestMethod]
    public void ShouldGetTotalCost()
    {
        var square = new Square();
        square.Side = 5;
        const string expectedMaterial = "Wood";
        square.Material = expectedMaterial;
        const int area = 25;
        const int expectedMaterialCost = 5;
        const int expectedCost = 25 * expectedMaterialCost;
        Assert.AreEqual(125, square.CalculateCost());
        
    }
}