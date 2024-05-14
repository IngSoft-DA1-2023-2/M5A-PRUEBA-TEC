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
    
    
    [TestMethod]
    public void ShouldGetCorrectShape()
    {
        Tile newTile = new Tile();
        string expectedShape = "circulo";
        newTile.Shape = expectedShape ;
        Assert.AreEqual(expectedShape, newTile.Shape);
    }
    
    [TestMethod]
    public void ShouldSetCorrectArea()
    {
        Tile newTile = new Tile();
        float expectedArea = 16;
        newTile.Area = expectedArea ;
        Assert.AreEqual(expectedArea, newTile.Area);
    }
    
    
    [TestMethod]
    public void ShouldGetCorrectArea()
    {
        Tile newTile = new Tile();
        float expectedArea = 16;
        newTile.Area = expectedArea ;
        Assert.AreEqual(expectedArea, newTile.Area);
    }

     
    [TestMethod]
    public void ShouldSetCorrectMaterialPrice()
    {
        Tile newTile = new Tile();
        float expectedMaterialprice = 3;
        newTile.MaterialPrice = expectedMaterialprice ;
        Assert.AreEqual(expectedMaterialprice, newTile.MaterialPrice);
    }
    
       
    [TestMethod]
    public void ShouldGetCorrectMaterialPrice()
    {
        Tile newTile = new Tile();
        float expectedMaterialprice = 3;
        newTile.MaterialPrice = expectedMaterialprice ;
        Assert.AreEqual(expectedMaterialprice, newTile.MaterialPrice);
    }


    [TestMethod]
    public void ShouldGetCorrectSingleTilePrice()
    {
        Tile newTile = new Tile();
        float expectedMaterialprice = 3;
        float expectedArea = 16;
        string expectedShape = "cuadrado";
        string expectedMaterial = "azulejo";
        
        newTile.MaterialPrice = expectedMaterialprice;
        newTile.Area = expectedArea;
        newTile.Shape = expectedShape;
        newTile.Material = expectedMaterial;
        Assert.AreEqual(newTile.GetSingleTilePrice(), newTile.MaterialPrice * newTile.Area);
        
    }

}