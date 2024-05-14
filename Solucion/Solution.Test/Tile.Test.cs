using Solucion;

namespace Solution.Test;

[TestClass]
public class Tile_Test
{
    
    [TestMethod]
    public void CalculatePriceShouldReturnCorrectValueForRectangle()
    {
        Rectangle rectangle = new Rectangle(2,3);
        Stone stone = new Stone();
        
        Tile tile = new Tile(rectangle, stone);
        double result = tile.CalculateTotalPrice();
        
        Assert.AreEqual(120, result);
    }
    
    [TestMethod]
    public void CalculatePriceShouldReturnCorrectValueForSquare()
    {
        Square square = new Square(5);
        Stone stone = new Stone();
        
        Tile tile = new Tile(square, stone);
        double result = tile.CalculateTotalPrice();
        
        Assert.AreEqual(500, result);
    }
}