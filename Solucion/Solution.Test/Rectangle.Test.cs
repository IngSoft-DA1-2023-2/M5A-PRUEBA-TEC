using Solucion;

namespace Solution.Test;

[TestClass]
public class Rectangle_Test
{
    [TestMethod]
    public void CalculateAreaShouldReturnCorrectValue()
    {
        Rectangle rectangle = new Rectangle(2,3);
        
        double result = rectangle.CalculateArea();
        
        Assert.AreEqual(6, result);
    }
}