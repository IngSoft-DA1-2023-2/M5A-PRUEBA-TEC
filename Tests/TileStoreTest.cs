using Baldoseria;

namespace Tests;

[TestClass]
public class TileStoreTest
{
    [TestMethod]
    public void TileStoreConstructor()
    {
        TileStore tileStore = new TileStore();
        Assert.IsNotNull(tileStore);
    }
    
    [TestMethod]
    public void TileStoreAddTile()
    {
        TileStore tileStore = new TileStore();
        Square square = new Square(5);
        Material material = new Material("Ceramic", 10);
        Tile tile = new Tile(square, material);
        tileStore.AddTile(tile);
        Assert.AreEqual(1, tileStore.Tiles.Count);
    }
    
    [TestMethod]
    public void TileStoreCalculateTotalPrice()
    {
        TileStore tileStore = new TileStore();
        Square square = new Square(5);
        Material material = new Material("Ceramic", 10);
        Tile tile = new Tile(square, material);
        tileStore.AddTile(tile);
        tileStore.AddTile(tile);
        Assert.AreEqual(500, tileStore.CalculateTotalPrice());
    }
    
    [TestMethod]
    public void TileStoreCalculateTotalArea()
    {
        TileStore tileStore = new TileStore();
        Square square = new Square(5);
        Material material = new Material("Ceramic", 10);
        Tile tile = new Tile(square, material);
        tileStore.AddTile(tile);
        tileStore.AddTile(tile);
        Assert.AreEqual(50, tileStore.CalculateTotalArea());
    }
    
    [TestMethod]
    public void TileStoreTotalTilesPrice()
    {
        TileStore tileStore = new TileStore();
        Square square = new Square(5);
        Material material = new Material("Ceramic", 10);
        Tile tile = new Tile(square, material);
        tileStore.AddTile(tile);
        tileStore.AddTile(tile);
        tileStore.TotalTilesPrice();
    }
    
    [TestMethod]
    public void TileStoreTiles()
    {
        TileStore tileStore = new TileStore();
        Square square = new Square(5);
        Material material = new Material("Ceramic", 10);
        Tile tile = new Tile(square, material);
        tileStore.AddTile(tile);
        tileStore.AddTile(tile);
        Assert.AreEqual(2, tileStore.Tiles.Count);
    }
}