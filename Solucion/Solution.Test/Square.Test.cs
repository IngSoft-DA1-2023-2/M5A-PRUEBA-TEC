using Solucion;

namespace Solution.Test;
[TestClass]
public class Square_Test
{
    [TestMethod]
    public void CalculateAreaShouldReturnCorrectValue()
    {
        Square square = new Square(5);
        
        double result = square.CalculateArea();
        
        Assert.AreEqual(25, result);
    }
}