namespace Baldosas.Test;

[TestClass]
public class CuadradoTest
{
    [TestMethod]
    public void CalcularAreaCuadrado()
    {
        
        var cuadrado = new Cuadrado(5);

    
        var result = cuadrado.Area();

      
        Assert.AreEqual(25, result);
    }
}