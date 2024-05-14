namespace Baldosas.Test;

[TestClass]
public class PiedraTest
{
    [TestMethod]
    public void CalcularrecioCeramica()
    {
        
        var cuadrado = new Piedra(5);

    
        var result = cuadrado.Precio();
        
        Assert.AreEqual(10, result);
    }
}