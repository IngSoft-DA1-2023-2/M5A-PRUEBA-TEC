using Solucion;

namespace Solution.Test;

[TestClass]
public class Main_Test
{
    [TestMethod]
    public void CalculateTotalPriceShouldReturnCorrectValue()
    {
        Main main = new Main();
        Tile tile1 = new Tile(new Rectangle(2,3), new Ceramic());
        Tile tile2 = new Tile(new Square(5), new Stone());
        main.AddTile(tile1);
        main.AddTile(tile2);
        double result = main.CalculateTotalPricePerArea();
        Assert.AreEqual(result, 560);
    }
}