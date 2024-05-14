namespace Backend.Test;

[TestClass]
public class UnitTestBaldosaRectangular
{
    [TestMethod]
    public void TestCrearBaldosaRectangular()
    {
        var baldosa = new BaldosaRectangular();
        Assert.IsNotNull(baldosa);
    }
    
    [TestMethod]
    public void TestCalcularAreaBaldosaCuadrada()
    {
        var baldosa = new BaldosaCuadrada();
        baldosa.Largo = 2;
        baldosa.Ancho = 2;
        baldosa.Material = "Porcelana";
        var resultadoEsperado = 4;
        var resultado = baldosa.CalcularArea();
        Assert.AreEqual(resultado,resultadoEsperado)
    }

}