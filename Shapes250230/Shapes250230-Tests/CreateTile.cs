namespace Shapes250230_Tests;

[TestClass]
public class CreateTile
{
    [TestMethod]
    public void ShouldCreateTile()
    {
        Tile newTile = new Tile();
        Assert.NotNull(newTile);
    }
}