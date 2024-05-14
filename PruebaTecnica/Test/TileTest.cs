using PruebaTecnica;

namespace Test;

[TestClass]
public class TileTest
{
    [TestMethod]
    public void CreateTypeCircleShouldBeValid()
    {
        var radio = 1;
        var circle = new Circle(radio);
        Assert.AreEqual(circle.Radio,radio);
    }

    [TestMethod]
    public void CreateTypeRectangularShouldBeValid()
    {
        var broad = 1;
        var side = 2;
        var rectangularTile = new Rectangular(side, broad);
        Assert.AreEqual(side, rectangularTile.Side);
        Assert.AreEqual(broad, rectangularTile.Broad);
    }
    

    [TestMethod]
    public void CalculateAreaOfCircleShouldBeValid()
    {
        var radio = 1;
        var circle = new Circle(radio);
        Assert.AreEqual(3.14, circle.CalculateArea());
    }

    [TestMethod]
    public void CalculateAreaOfRectangularShouldBeValid()
    {
        var broad = 1;
        var side = 2;
        var material = new CeramicMaterial("ladri", 1);
        var rect = new Rectangular(1, 1,material);
        Assert.AreEqual(2,rect.CalculateArea());
    }
    
    [TestMethod]
    public void CreateCeramicMaterialShoulBeValid()
    {
        var material = new CeramicMaterial("ladri", 1);
        Assert.AreEqual("ladri",material.Name);
        Assert.AreEqual(1,material.Price);
    }

    [TestMethod]
    public void AddTailToRepositoryShouldBeValid
}