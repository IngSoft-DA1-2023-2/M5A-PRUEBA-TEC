namespace Baldosas.Test;

[TestClass]
public class BaldosaTest
{
    [TestMethod]
    public void CalcularAreaCuadrado()
    {
        
       
        var cuadrado = new Cuadrado(5);
        var piedra = new Piedra(10);
        var baldosa = new Baldosa(cuadrado, piedra);

     
        baldosa.ListaDeBaldosas.Add(baldosa);

        
        Assert.AreEqual(cuadrado, baldosa.Area);
        Assert.AreEqual(piedra, baldosa.Material);
    }
}