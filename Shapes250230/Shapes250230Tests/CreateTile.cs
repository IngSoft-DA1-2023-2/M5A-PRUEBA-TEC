using Shapes250230;

namespace Shapes250230Tests;



[TestClass]
public class CreateTile
{
    [TestMethod]
    public void ShouldCreateTile()
    {
        Tile newTile = new Tile();
        Assert.IsNotNull(newTile);
    }
    
    [TestMethod]
    public void ShouldSetCorrectMaterial()
    {
        Tile newTile = new Tile();
        string expectedMaterial = "piedra";
        newTile.Material = expectedMaterial;
        Assert.AreEqual(expectedMaterial, newTile.Material);
    }
    
    [TestMethod]
    public void ShouldGetCorrectMaterial()
    {
        Tile newTile = new Tile();
        string expectedMaterial = "basalto";
        newTile.Material = expectedMaterial;
        Assert.AreEqual(expectedMaterial, newTile.Material);
    }
    
    [TestMethod]
    public void ShouldSetCorrectShape()
    {
        Tile newTile = new Tile();
        string expectedShape = "cuadrado";
        newTile.Shape = expectedShape ;
        Assert.AreEqual(expectedShape, newTile.Shape);
    }
}