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
}