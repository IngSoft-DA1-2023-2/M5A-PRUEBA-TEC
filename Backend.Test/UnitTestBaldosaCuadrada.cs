namespace Backend.Test;

[TestClass]
public class UnitTestBaldosaCuadrada
{
    [TestMethod]
    public void TestCrearBaldosaCuadrada()
    {
        var baldosa = new BaldosaRectangular();
        Assert.IsNotNull(baldosa);
    }
    
    [TestMethod]
    public void TestCalcularAreaBaldosaRectangular()
    {
        var baldosa = new BaldosaRectangular();
        baldosa.largo = 2;
        baldosa.ancho = 3;
        baldosa.Material = "Tierra";
        var resultadoEsperado = 6;
        var resultado = baldosa.CalcularArea();
        Assert.AreEqual(resultado,resultadoEsperado);
    }

}